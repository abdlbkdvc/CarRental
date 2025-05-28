using CarRental.Dto.Banner2Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CarRental.WebUI.Areas.UI.ViewComponents
{
    public class Banner2UIComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public Banner2UIComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44318/api/Banner2s");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var datas = JsonConvert.DeserializeObject<List<ResultBanner2Dto>>(jsonData);
                return View(datas);
            }
            return View();
        }
    }
}
