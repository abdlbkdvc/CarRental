using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.UI.ViewComponents.LayoutComponents
{
    public class PageHeaderUIComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
