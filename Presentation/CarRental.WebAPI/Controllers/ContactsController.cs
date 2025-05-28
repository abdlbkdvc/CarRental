using CarRental.Application.Features.Mediator.Commands.AboutCommands;
using CarRental.Application.Features.Mediator.Commands.ContactCommands;
using CarRental.Application.Features.Mediator.Queries.AboutQueries;
using CarRental.Application.Features.Mediator.Queries.ContactQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllContactList()
        {
            var result = await _mediator.Send(new GetContactListQuery());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactById(int id)
        {
            var result = await _mediator.Send(new GetContactByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand command)
        {
            await _mediator.Send(command);
            return Ok("İletişim Bilgisi Oluşturuldu.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
        {
            await _mediator.Send(command);
            return Ok("İletişim Bilgisi Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _mediator.Send(new RemoveContactCommand(id));
            return Ok("İletişim Bilgisi Silindi.");
        }
    }
}
