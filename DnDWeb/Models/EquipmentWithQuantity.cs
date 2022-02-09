using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWeb.Models
{
    public class EquipmentWithQuantity
    {
        public ApiItem equipment { get; set; }
        public int quantity { get; set; }
    }
}
