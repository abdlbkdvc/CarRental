using CarRental.Dto.ServiceDtos;
using CarRental.Dto.TeamMemberDtos;
using CarRental.WebUI.Validation.Service;
using CarRental.WebUI.Validation.TeamMember;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarRental.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class TeamMemberController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TeamMemberController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:44318/api/TeamMembers");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var datas = JsonConvert.DeserializeObject<List<ResultTeamMemberDto>>(jsonData);
                return View(datas);
            }

            return View();
        }
        public async Task<IActionResult> CreateTeamMember()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTeamMember(CreateTeamMemberDto createTeamMemberDto)
        {
            var validator = new CreateTeamMemberValidation();
            var result = await validator.ValidateAsync(createTeamMemberDto);
            if (!result.IsValid)
            {
                ModelState.Clear();
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createTeamMemberDto);
            var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:44318/api/TeamMembers", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> DeleteTeamMember(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:44318/api/TeamMembers?id={id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateTeamMember(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:44318/api/TeamMembers/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<UpdateTeamMemberDto>(jsonData);
                return View(data);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTeamMember(UpdateTeamMemberDto updateTeamMemberDto)
        {
            var validator = new UpdateTeamMemberValidation();
            var result = await validator.ValidateAsync(updateTeamMemberDto);
            if (!result.IsValid)
            {
                ModelState.Clear();
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateTeamMemberDto);
            var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://localhost:44318/api/TeamMembers", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
