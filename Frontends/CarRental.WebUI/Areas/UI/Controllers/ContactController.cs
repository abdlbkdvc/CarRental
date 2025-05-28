using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.UI.Controllers
{
    [Area("UI")]
    [Route("UI/[controller]/[action]/{id?}")]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.V1 = "İletişim";
            ViewBag.V2 = "Bilgiler";
            return View();
        }
    }
}
