using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Förlossningsstatistik.Models
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            Items = new List<Item>();
        }

        public List<Item> Items { get; set; }
        public int? Page { get; set; }

        //{"variabelId":"V22","regionId":110,"alderId":0,"paritetId":0,"mattId":1,"ar":2016,"varde":"18856"}
        public class Item
        {
            public string Variable { get; set; }
            public string Region { get; set; }
            public string AgeSpan { get; set; }
            public string Parity { get; set; }
            public int Year { get; set; }
            public int Babies { get; set; }
        }
    }
}
