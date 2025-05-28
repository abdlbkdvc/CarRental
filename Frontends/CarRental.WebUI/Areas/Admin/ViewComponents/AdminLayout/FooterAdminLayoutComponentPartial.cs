using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.Admin.ViewComponents.AdminLayout
{
    public class FooterAdminLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
