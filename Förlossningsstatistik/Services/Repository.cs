using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Förlossningsstatistik.Services.Models;
using RestSharp;

namespace Förlossningsstatistik.Services
{
    public class Repository
    {
        //http://sdb.socialstyrelsen.se/sdbapi.aspx
        private static string baseUrl = "http://sdb.socialstyrelsen.se/api/v1/sv/graviditeterforlossningarochnyfodda/";

        //http://sdb.socialstyrelsen.se/api/v1/sv/graviditeterforlossningarochnyfodda/resultat?sida=1
        public IRestResponse Babies()
        {
            IRestResponse result = null;

            var client = new RestClient(baseUrl);
            var request = new RestRequest("resultat", Method.GET);
            result = client.Execute<Baby>(request);

            return result;
        }


        //http://sdb.socialstyrelsen.se/api/v1/sv/graviditeterforlossningarochnyfodda/alder
        public IRestResponse Age()
        {
            IRestResponse result = null;

            var client = new RestClient(baseUrl);
            var request = new RestRequest("alder", Method.GET);
            result = client.Execute<Age>(request);

            return result;
        }

        //paritet betyder om föderskan är förstföderska eller omföderska
        //http://sdb.socialstyrelsen.se/api/v1/sv/graviditeterforlossningarochnyfodda/paritet
        public IRestResponse Parity()
        {
            IRestResponse result = null;

            var client = new RestClient(baseUrl);
            var request = new RestRequest("paritet", Method.GET);
            result = client.Execute<Parity>(request);

            return result;
        }

        //variabel betyder de olika tillstånd som uppkommer före och vid förlossning
        //http://sdb.socialstyrelsen.se/api/v1/sv/graviditeterforlossningarochnyfodda/variabel
        public IRestResponse Variable()
        {
            IRestResponse result = null;

            var client = new RestClient(baseUrl);
            var request = new RestRequest("variabel", Method.GET);
            result = client.Execute<Variable>(request);

            return result;
        }

        //http://sdb.socialstyrelsen.se/api/v1/sv/graviditeterforlossningarochnyfodda/region
        public IRestResponse Region()
        {
            IRestResponse result = null;

            var client = new RestClient(baseUrl);
            var request = new RestRequest("region", Method.GET);
            result = client.Execute<Region>(request);

            return result;
        }
    }
}
