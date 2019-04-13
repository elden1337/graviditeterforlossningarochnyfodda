using Förlossningsstatistik.Services.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Förlossningsstatistik.Services
{
    public class Service
    {
        Repository r = new Repository();

        public List<Baby.Item> Babies()
        {
            var result = new List<Baby.Item>();
            var queryResult = r.Babies();
            var preresult = JsonConvert.DeserializeObject<Baby>(queryResult.Content);
            result = preresult.data;

            return result;
        }

        public List<Age> Age()
        {
            var result = new List<Age>();
            var queryResult = r.Age();
            result = JsonConvert.DeserializeObject<List<Age>>(queryResult.Content);

            return result;
        }

        public List<Parity> Parity()
        {
            var result = new List<Parity>();
            var queryResult = r.Parity();
            result = JsonConvert.DeserializeObject<List<Parity>>(queryResult.Content);

            return result;
        }

        public List<Variable> Variable()
        {
            var result = new List<Variable>();
            var queryResult = r.Variable();
            result = JsonConvert.DeserializeObject<List<Variable>>(queryResult.Content);

            return result;
        }

        public List<Region> Region()
        {
            var result = new List<Region>();
            var queryResult = r.Region();
            result = JsonConvert.DeserializeObject<List<Region>>(queryResult.Content);

            return result;
        }

    }
}
