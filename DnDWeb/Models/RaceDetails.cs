using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWeb.Models
{
    public class RaceDetails
    {
        public string index { get; set; }
        public string name { get; set; }
        public int speed { get; set; }
        public string alignment { get; set; }
        public string age { get; set; }
        public string size { get; set; }
        public List<ApiItem> languages { get; set; }
        public string language_desc { get; set; }
        public List<ApiItem> traits { get; set; }
    }
}
