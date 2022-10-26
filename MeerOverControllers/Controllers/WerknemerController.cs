using Microsoft.AspNetCore.Mvc;

namespace MeerOverControllers.Controllers
{
    public class WerknemerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [NonAction]
        public string HuidigeDatum()
        {
            return DateTime.Now.ToShortDateString();
        }
    }
}
