using CarRental.Dto.ContactInformationDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarRental.WebUI.Areas.UI.ViewComponents
{
    public class ContactInformationComponentPartial : ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public ContactInformationComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44318/api/ContactInformations");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var datas = JsonConvert.DeserializeObject<List<ResultContactInformationDto>>(jsonData);
                return View(datas);
            }
            return View();
        }
    }
}
