using CarRental.Application.Features.Mediator.Commands.AboutCommands;
using CarRental.Application.Features.Mediator.Commands.TeamMemberCommands;
using CarRental.Application.Features.Mediator.Queries.AboutQueries;
using CarRental.Application.Features.Mediator.Queries.TeamMemberQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TeamMembersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTeamMemberList()
        {
            var result = await _mediator.Send(new GetTeamMemberListQuery());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeamMemberById(int id)
        {
            var result = await _mediator.Send(new GetTeamMemberByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTeamMember(CreateTeamMemberCommand command)
        {
            await _mediator.Send(command);
            return Ok("Takım Üyesi Oluşturuldu.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTeamMember(UpdateTeamMemberCommand command)
        {
            await _mediator.Send(command);
            return Ok("Takım Üyesi Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTeamMember(int id)
        {
            await _mediator.Send(new RemoveTeamMemberCommand(id));
            return Ok("Takım Üyesi Silindi.");
        }
    }
}
