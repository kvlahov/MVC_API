using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Zadatak1.Models;

namespace Zadatak1.Controllers
{
    public class HomeController : Controller
    {
        private readonly BeerRESTService service = new BeerRESTService();

        // GET 
        public async Task<ActionResult> Index()
        {
            var beers = await service.GetBeers();
            return View(beers);
        }

        public ActionResult GetRandom()
        {
            return View();
        }

        public async Task<ActionResult> GetRandomBeer()
        {
            IList<Beer> beers = new List<Beer>();
            beers.Add(await service.GetRandomBeer());
            return PartialView("_BeerList", beers);
        }

        [HttpPost]
        public async Task<ActionResult> GetBeersFiltered(List<QueryFilter> filters)
        {
            if(filters == null)
            {
                return PartialView("_BeerList", await service.GetBeers());
            }
            return PartialView("_BeerList", await service.GetBeers(filters));
        }

    }
}