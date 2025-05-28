using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.UI.ViewComponents.LayoutComponents
{
    public class HeaderUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
