using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.UI.Controllers
{
    [Area("UI")]
    [Route("UI/[controller]/[action]/{id?}")]
    public class TestimonialController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.V1 = "Müşterilerimizin Yorumları";
            ViewBag.V2 = "Bilgiler";
            return View();
        }
    }
}
