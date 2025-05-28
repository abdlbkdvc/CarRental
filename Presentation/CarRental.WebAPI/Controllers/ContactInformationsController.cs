using CarRental.Application.Features.Mediator.Commands.AboutCommands;
using CarRental.Application.Features.Mediator.Commands.ContactInformationCommands;
using CarRental.Application.Features.Mediator.Queries.AboutQueries;
using CarRental.Application.Features.Mediator.Queries.ContactInformationQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactInformationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactInformationsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllContactInformationList()
        {
            var result = await _mediator.Send(new GetContactInformationListQuery());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactInformationById(int id)
        {
            var result = await _mediator.Send(new GetContactInformationByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContactInformation(CreateContactInformationCommand command)
        {
            await _mediator.Send(command);
            return Ok("İletişim Bilgisi 2 Oluşturuldu.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContactInformation(UpdateContactInformationCommand command)
        {
            await _mediator.Send(command);
            return Ok("İletişim Bilgisi 2 Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteContactInformation(int id)
        {
            await _mediator.Send(new RemoveContactInformationCommand(id));
            return Ok("İletişim Bilgisi 2 Silindi.");
        }
    }
}
