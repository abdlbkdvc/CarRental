using CarRental.Dto.AboutDtos;
using CarRental.Dto.InformationDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarRental.WebUI.Areas.UI.ViewComponents.LayoutComponents
{
    public class AboutUIComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AboutUIComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44318/api/Abouts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var datas = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
                return View(datas);
            }
            return View();
        }
    }
}
