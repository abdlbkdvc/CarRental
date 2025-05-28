using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.UI.Controllers
{
    public class TeamController : Controller
    {
        [Area("UI")]
        [Route("UI/[controller]/[action]/{id?}")]
        public IActionResult Index()
        {
            ViewBag.V1 = "Takımımız";
            ViewBag.V2 = "Bilgiler";
            return View();
        }
    }
}
