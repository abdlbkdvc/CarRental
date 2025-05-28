using CarRental.Dto.AboutDtos;
using CarRental.Dto.Banner1Dtos;
using CarRental.WebUI.Validation.About;
using CarRental.WebUI.Validation.Banner1;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarRental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class Banner1Controller : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public Banner1Controller(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:44318/api/Banner1s");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var datas = JsonConvert.DeserializeObject<List<ResultBanner1Dto>>(jsonData);
                return View(datas);
            }

            return View();
        }
        public async Task<IActionResult> CreateBanner1()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner1(CreateBanner1Dto createBanner1Dto)
        {
            var validator = new CreateBanner1Validation();
            var result = await validator.ValidateAsync(createBanner1Dto);
            if (!result.IsValid)
            {
                ModelState.Clear();
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBanner1Dto);
            var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:44318/api/Banner1s", content);
            if (response.IsSuccessStatusCode)
            {
                ModelState.Clear();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> DeleteBanner1(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:44318/api/Banner1s?id={id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateBanner1(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:44318/api/Banner1s/{id}");
            if (response.IsSuccessStatusCode)
            {
                ModelState.Clear();
                var jsonData = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<UpdateBanner1Dto>(jsonData);
                return View(data);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBanner1(UpdateBanner1Dto updateBanner1Dto)
        {
            var validator = new UpdateBanner1Validation();
            var result = await validator.ValidateAsync(updateBanner1Dto);
            if (!result.IsValid)
            {
                ModelState.Clear();
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateBanner1Dto);
            var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://localhost:44318/api/Banner1s", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
