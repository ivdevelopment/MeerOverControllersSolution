using Microsoft.AspNetCore.Mvc;

namespace MeerOverControllers.Controllers
{
    public class WerknemerController : Controller
    {
        public IActionResult Index()
        {
            /*return Content("Kiekeboe");*/
            return File(@"images\happy.png", "image/png");
        }

        /*public IActionResult Detail()
        {
            return View();
        }*/

        public IActionResult Detail(int? id)
        {
            return View();
        }

        public IActionResult VerdubbelDeWeddes()
        {
            // update in de database
            //.....
            return Redirect("~/Werknemer/WeddesAangepast");
        }

        public IActionResult WeddesAangepast()
        {
            return View();
        }

        public IActionResult EvenOfOneven(int id)
        {
            if (id % 2 == 0)
                return View("Even");
            else
                return View("Oneven");
        }

        public IActionResult Alfa()
        {
            return View("Beta");
        }

        [NonAction]
        public string HuidigeDatum()
        {
            return DateTime.Now.ToShortDateString();
        }
    }
}
