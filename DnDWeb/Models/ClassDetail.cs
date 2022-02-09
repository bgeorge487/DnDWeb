using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWeb.Models
{
    public class ClassDetail
    {
        public string index { get; set; }
        public string name { get; set; }
        public int hit_die { get; set; }
        public List<EquipmentWithQuantity> starting_equipment { get; set; }
        public SpellcastingApi spellcasting { get; set; }
    }
}
