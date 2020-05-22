using System;
using System.Collections.Generic;
using System.Text;

namespace Buka.Entity
{
   public  class BukaModel

    {
        public BukaModel()
        {
            Ready = DateTime.Now;
        }
        public int Id { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public DateTime Ready { get; set; }


        public int MyProperty { get; set; }
    }
}
