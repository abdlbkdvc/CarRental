using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.Admin.ViewComponents.AdminLayout
{
    public class HeaderAdminLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
