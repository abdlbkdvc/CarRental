using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.Admin.ViewComponents.AdminLayout
{
    public class AsideAdminLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
