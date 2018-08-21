using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhyWhere.Models;

namespace WhyWhere.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();


        //Get Index
        public ActionResult Index()
        {
            var model = new CountryModel();
            model.countries = db.CountryModels.ToList();

            return View(model);
        }
        [HttpPost]
        public ActionResult Selection(CountryModel model) {

            return View(db.Cities.Where(m => m.country == model.selectedCountry).ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()

        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}