using CarRental.Application.Features.Mediator.Commands.AboutCommands;
using CarRental.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarRental.Application.Features.Mediator.Queries.AboutQueries;
using CarRental.Application.Features.Mediator.Queries.FooterAddressQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAddressesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FooterAddressesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFooterAddressList()
        {
            var result = await _mediator.Send(new GetFooterAddressListQuery());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooterAddressById(int id)
        {
            var result = await _mediator.Send(new GetFooterAddressByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Alt Bilgi Oluşturuldu.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Alt Bilgi Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFooterAddress(int id)
        {
            await _mediator.Send(new RemoveFooterAddressCommand(id));
            return Ok("Alt Bilgi Silindi.");
        }
    }
}
