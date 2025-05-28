using CarRental.Dto.Banner3Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarRental.WebUI.Areas.UI.ViewComponents
{
    public class Banner3UIComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public Banner3UIComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44318/api/Banner3s");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var datas = JsonConvert.DeserializeObject<List<ResultBanner3Dto>>(jsonData);
                return View(datas);
            }
            return View();
        }
    }
}
