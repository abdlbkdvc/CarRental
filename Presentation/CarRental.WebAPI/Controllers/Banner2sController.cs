using CarRental.Application.Features.Mediator.Commands.Banner1Commands;
using CarRental.Application.Features.Mediator.Commands.Banner2Commands;
using CarRental.Application.Features.Mediator.Queries.Banner1Queries;
using CarRental.Application.Features.Mediator.Queries.Banner2Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Banner2sController : ControllerBase
    {
        private readonly IMediator _mediator;

        public Banner2sController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBanner2List()
        {
            var result = await _mediator.Send(new GetBanner2ListQuery());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBanner2ById(int id)
        {
            var result = await _mediator.Send(new GetBanner2ByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner2(CreateBanner2Command command)
        {
            await _mediator.Send(command);
            return Ok("Banner2 Oluşturuldu.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBanner2(UpdateBanner2Command command)
        {
            await _mediator.Send(command);
            return Ok("Banner2 Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBanner2(int id)
        {
            await _mediator.Send(new RemoveBanner2Command(id));
            return Ok("Banner2 Silindi.");
        }
    }
}
