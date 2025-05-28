using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.UI.Controllers
{
    [Area("UI")]
    [Route("UI/[controller]/[action]/{id?}")]
    public class CarListController : Controller
    {
        public IActionResult Index()
        {
            @ViewBag.V1 = "Anasayfa";
            @ViewBag.V2="Araba Listesi";
            return View();
        }
    }
}
