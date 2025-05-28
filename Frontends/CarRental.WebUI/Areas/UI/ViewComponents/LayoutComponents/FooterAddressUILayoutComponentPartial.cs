using CarRental.Dto.FooterAddressDtos;
using CarRental.Dto.InformationDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarRental.WebUI.Areas.UI.ViewComponents.LayoutComponents
{
    public class FooterAddressUILayoutComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FooterAddressUILayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44318/api/FooterAddresses");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var datas = JsonConvert.DeserializeObject<List<ResultFooterAddressDto>>(jsonData);
                return View(datas);
            }
            return View();
        }
    }
}
