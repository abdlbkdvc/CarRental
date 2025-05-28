using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.UI.ViewComponents.LayoutComponents
{
    public class ScriptUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
