using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.UI.Controllers
{
    public class ServiceController : Controller
    {
        [Area("UI")]
        [Route("UI/[controller]/[action]/{id?}")]
        public IActionResult Index()
        {
            ViewBag.V1 = "Servisler";
            ViewBag.V2 = "Bilgiler";
            return View();
        }
    }
}
