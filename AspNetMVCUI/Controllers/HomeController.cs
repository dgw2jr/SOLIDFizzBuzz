using System.Web.Mvc;
using AspNetMVCUI.Models;
using SOLIDFizzBuzz;

namespace AspNetMVCUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDividendProcessor processor;

        public HomeController(IDividendProcessor processor)
        {
            this.processor = processor;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FizzBuzzModel model)
        {
            ViewBag.Result = this.processor.Process(model.Number);

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}