using CarRental.Application.Features.Mediator.Commands.Banner2Commands;
using CarRental.Application.Features.Mediator.Commands.Banner3Commands;
using CarRental.Application.Features.Mediator.Queries.Banner2Queries;
using CarRental.Application.Features.Mediator.Queries.Banner3Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Banner3sController : ControllerBase
    {
        private readonly IMediator _mediator;

        public Banner3sController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBanner3List()
        {
            var result = await _mediator.Send(new GetBanner3ListQuery());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBanner3ById(int id)
        {
            var result = await _mediator.Send(new GetBanner3ByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner3(CreateBanner3Command command)
        {
            await _mediator.Send(command);
            return Ok("Banner3 Oluşturuldu.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBanner3(UpdateBanner3Command command)
        {
            await _mediator.Send(command);
            return Ok("Banner3 Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBanner3(int id)
        {
            await _mediator.Send(new RemoveBanner3Command(id));
            return Ok("Banner3 Silindi.");
        }
    }
}
