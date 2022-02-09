using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWeb.Models
{
    public class Equipment
    {
        public string index { get; set; }
        public string name { get; set; }
        public string armor_category { get; set; }
        public double weight { get; set; }
        public CostApi cost { get; set; }
    }
}
