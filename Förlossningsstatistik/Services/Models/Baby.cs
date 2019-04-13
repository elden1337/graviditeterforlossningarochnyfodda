using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Förlossningsstatistik.Services.Models
{
    public class Baby
    {
        public Baby()
        {
            data = new List<Item>();
        }

        public List<Item> data { get; set; }
        public string amne { get; set; }
        public string nasta_sida { get; set; }
        public string foregaende_sida { get; set; }
        public int sida { get; set; }
        public int per_sida { get; set; }
        public int sidor { get; set; }

        public class Item
        {
            public string variabelId { get; set; }
            public int regionId { get; set; }
            public int alderId { get; set; }
            public int paritetId { get; set; }
            public int mattId { get; set; }
            public int ar { get; set; }
            public string varde { get; set; }
        }
    }

}


