using System;
using System.Collections.Generic;
using System.Text;

namespace Buka.Entity
{
    public class MenuModel
    {
        public int Id { get; set; }
        public int BukaModelId { get; set; }

        public string ChiefName { get; set; }
        public string MenuName { get; set; }
        public bool Approved { get; set; }

        public decimal Price { get; set; }


    }
}
