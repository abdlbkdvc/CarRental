using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.UI.Controllers
{
    [Area("UI")]
    [Route("UI/[controller]/[action]/{id?}")]
    public class CarDetailController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.V1 = "Araba Detayları";
            ViewBag.V2 = "Bilgiler";
            return View();
        }
    }
}
