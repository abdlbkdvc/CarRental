using CarRental.Application.Features.Mediator.Commands.AboutCommands;
using CarRental.Application.Features.Mediator.Commands.Banner1Commands;
using CarRental.Application.Features.Mediator.Queries.AboutQueries;
using CarRental.Application.Features.Mediator.Queries.Banner1Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Banner1sController : ControllerBase
    {
        private readonly IMediator _mediator;

        public Banner1sController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBanner1List()
        {
            var result = await _mediator.Send(new GetBanner1ListQuery());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBanner1ById(int id)
        {
            var result = await _mediator.Send(new GetBanner1ByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner1(CreateBanner1Command command)
        {
            await _mediator.Send(command);
            return Ok("Banner1 Oluşturuldu.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBanner1(UpdateBanner1Command command)
        {
            await _mediator.Send(command);
            return Ok("Banner1 Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBanner1(int id)
        {
            await _mediator.Send(new RemoveBanner1Command(id));
            return Ok("Banner1 Silindi.");
        }
    }
}
