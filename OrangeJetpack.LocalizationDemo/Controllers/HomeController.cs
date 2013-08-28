using System.Web.Mvc;
using OrangeJetpack.Localization;
using OrangeJetpack.LocalizationDemo.Models;

namespace OrangeJetpack.LocalizationDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly PlanetsContext _db = new PlanetsContext();

        public ActionResult Index(string langCode = "en")
        {
            var planets = _db.Planets.Localize(langCode, i => i.Name);

            return View(planets);
        }

        public ActionResult AddPlanet()
        {
            var planet = new Planet
                {
                    Name = LocalizedContent.Init()
                };

            return View(planet);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult AddPlanet(Planet planet, LocalizedContent[] name)
        {
            planet.Name = name.Serialize();

            _db.Planets.Add(planet);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
