using CarRental.Dto.ContactDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebUI.Areas.UI.Controllers
{
    public class FirstPageController : Controller
    {
        [Area("UI")]
        [Route("UI/[controller]/[action]/{id?}")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Contact(ResultContactDto resultContactDto)
        //{
        //    var validator = new ContactValidator();
        //    var result = await validator.ValidateAsync(resultContactDto);

        //    if (!result.IsValid)
        //    {
        //        foreach (var item in result.Errors)
        //        {
        //            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        //        }
        //        return View(resultContactDto); // DTO geri dönmeli
        //    }


        //    return RedirectToAction(nameof(Index));
        //}

    }
}
