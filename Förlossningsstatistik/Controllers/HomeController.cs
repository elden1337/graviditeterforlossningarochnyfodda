using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Förlossningsstatistik.Models;
using Förlossningsstatistik.Services;
using Förlossningsstatistik.Services.Models;

namespace Förlossningsstatistik.Controllers
{
    public class HomeController : Controller
    {
        Service s = new Service();

        public IActionResult Index(IndexViewModel model)
        {
            model = new IndexViewModel();
            var ages = new List<Age>();
            var parities = new List<Parity>();
            var regions = new List<Region>();
            var variables = new List<Variable>();
            var babies = new List<Baby.Item>();
            
            ages = s.Age();
            parities = s.Parity();
            regions = s.Region();
            variables = s.Variable();
            babies = s.Babies();

            foreach (var baby in babies.Where(x => x.alderId != 0 && x.paritetId != 0 && x.regionId != 0))
            {
                var convertedBaby = Convert(baby, ages, parities, regions, variables);
                model.Items.Add(convertedBaby);
            }

            return View(model);
        }

        private int ConvertStringNumbers(string value)
        {
            if(!int.TryParse(value, out int result))
            {
                result = 0;
            }

            return result;
        }

        private IndexViewModel.Item Convert(Baby.Item baby, List<Age> ages, List<Parity> parities, List<Region> regions, List<Variable> variables)
        {
            var result = new IndexViewModel.Item();

            result.Babies = ConvertStringNumbers(baby.varde);
            result.Year = baby.ar;
            result.AgeSpan = ages.Where(x => x.id == baby.alderId).Select(x => x.text).SingleOrDefault();
            result.Parity = parities.Where(x => x.id == baby.paritetId).Select(x => x.text).SingleOrDefault();
            result.Variable = variables.Where(x => x.id == baby.variabelId).Select(x => x.text).SingleOrDefault();
            result.Region = regions.Where(x => x.id == baby.regionId).Select(x => x.text).SingleOrDefault();
            
            return result;
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
