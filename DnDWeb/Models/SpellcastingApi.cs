using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWeb.Models
{
    public class SpellcastingApi
    {
        public int level { get; set; }
        public ApiItem spellcasting_ability { get; set; }
        public List<NameDescriptionApi> info { get; set; }
    }
}
