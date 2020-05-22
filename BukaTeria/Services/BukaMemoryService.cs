using Buka.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BukaTeria.Services
{
    public class BukaMemoryService : IBukaService
    {
        private readonly List<BukaModel> bukas = new List<BukaModel>();
        public BukaMemoryService()
        {
            bukas.Add(new BukaModel { Id = 1, BukaName = "Biggs",  Address = "Ikoyi" , OrderType = OnlineOrder.Yes});
            bukas.Add(new BukaModel { Id = 2, BukaName = "Dominos",  Address = "VI", OrderType = OnlineOrder.No });
            bukas.Add(new BukaModel { Id = 3, BukaName = "Senstations",  Address = "Shomolu" , OrderType = OnlineOrder.Yes});
        }


        public Task Add(BukaModel model)
        {
            model.Id = bukas.Max(c => c.Id) + 1;
            bukas.Add(model);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<BukaModel>> GetAll()
        {
            return Task.Run(() => bukas.AsEnumerable());
        }

        public Task<BukaModel> GetbyId(int id)
        {
            return Task.Run(() => bukas.First(c => c.Id == id));
        }

        public Task<StatisticsModel> GetStatistics()
        {
            return Task.Run(()=>
            {
                return new StatisticsModel
                {
                    NumberOfCustomers =  bukas.Sum(c => c.TotalCustomer),
                    AverageBukaCustomers = bukas.Average(c => c.)

                };
            
            
            
            })
        }
    }
}
