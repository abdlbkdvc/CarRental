using CarRental.Application.Features.Mediator.Commands.AboutCommands;
using CarRental.Application.Features.Mediator.Commands.BrandIconCommands;
using CarRental.Application.Features.Mediator.Queries.AboutQueries;
using CarRental.Application.Features.Mediator.Queries.BrandIconQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandIconsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandIconsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBrandIconList()
        {
            var result = await _mediator.Send(new GetBrandIconListQuery());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandIconById(int id)
        {
            var result = await _mediator.Send(new GetBrandIconByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBrandIcon(CreateBrandIconCommand command)
        {
            await _mediator.Send(command);
            return Ok("Marka İkonu Oluşturuldu.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBrandIcon(UpdateBrandIconCommand command)
        {
            await _mediator.Send(command);
            return Ok("Marka İkonu Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBrandIcon(int id)
        {
            await _mediator.Send(new RemoveBrandIconCommand(id));
            return Ok("Marka İkonu Silindi.");
        }
    }
}
