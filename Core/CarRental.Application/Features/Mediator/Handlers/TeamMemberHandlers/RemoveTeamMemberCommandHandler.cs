using CarRental.Application.Features.Mediator.Commands.TeamMemberCommands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.TeamMemberHandlers
{
    public class RemoveTeamMemberCommandHandler : IRequestHandler<RemoveTeamMemberCommand>
    {
        private readonly IRepository<TeamMember> _repository;

        public RemoveTeamMemberCommandHandler(IRepository<TeamMember> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveTeamMemberCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(values);
        }
    }
}
