using CarRental.Dto.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CarRental.WebUI.Areas.UI.ViewComponents
{
    public class ServiceUIComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ServiceUIComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44318/api/Services");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var datas = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                return View(datas);
            }
            return View();
        }
    }
}
