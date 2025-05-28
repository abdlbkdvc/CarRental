using CarRental.Application.Features.Mediator.Commands.AboutCommands;
using CarRental.Application.Features.Mediator.Commands.InformationCommands;
using CarRental.Application.Features.Mediator.Queries.AboutQueries;
using CarRental.Application.Features.Mediator.Queries.InformationQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public InformationsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllInformationList()
        {
            var result = await _mediator.Send(new GetInformationListQuery());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInformationById(int id)
        {
            var result = await _mediator.Send(new GetInformationByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateInformation(CreateInformationCommand command)
        {
            await _mediator.Send(command);
            return Ok("Bilgi Oluşturuldu.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateInformation(UpdateInformationCommand command)
        {
            await _mediator.Send(command);
            return Ok("Bilgi Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteInformation(int id)
        {
            await _mediator.Send(new RemoveInformationCommand(id));
            return Ok("Bilgi Silindi.");
        }
    }
}
