using Buka.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BukaTeria.Services
{
    public interface IBukaService
    {
        Task<IEnumerable<BukaModel>> GetAll();
        Task<BukaModel> GetbyId(int id);
       
        Task Add(BukaModel model);
        Task <StatisticsModel> GetStatistics();


    }
}
