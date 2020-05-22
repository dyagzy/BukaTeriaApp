using System;
using System.Collections.Generic;
using System.Text;

namespace Buka.Entity
{
    public class FoodMenu
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public bool Approved { get; set; }
        public string Cook { get; set; }
        public string Title { get; set; }
    }
}
