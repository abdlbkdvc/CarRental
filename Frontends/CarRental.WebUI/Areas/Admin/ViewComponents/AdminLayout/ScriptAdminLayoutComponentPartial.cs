using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.Admin.ViewComponents.AdminLayout
{
    public class ScriptAdminLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
