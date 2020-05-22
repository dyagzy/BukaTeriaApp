using System;
using System.Collections.Generic;
using System.Text;

namespace Buka.Entity
{
   public  class BukaModel

    {
        public BukaModel()
        {
            //Ready = DateTime.Now;
        }
        public int Id { get; set; }
        public string BukaName { get; set; }
        public decimal Price { get; set; }
        public OnlineOrder OrderType { get; set; }
        
        //public DateTime Ready { get; set; }


        public string Address { get; set; }
        public int TotalCustomer { get; set; }
    }
}
