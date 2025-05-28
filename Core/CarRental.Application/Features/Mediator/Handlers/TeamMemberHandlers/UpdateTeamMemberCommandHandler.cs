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
    public class UpdateTeamMemberCommandHandler : IRequestHandler<UpdateTeamMemberCommand>
    {
        private readonly IRepository<TeamMember> _repository;

        public UpdateTeamMemberCommandHandler(IRepository<TeamMember> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTeamMemberCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.TeamMemberID);
            values.PhotoUrl = request.PhotoUrl;
            values.MemberName = request.MemberName;
            values.MemberJob = request.MemberJob;
            values.MemberIsActive = request.MemberIsActive;
            values.TwitterUrl = request.TwitterUrl;
            values.FacebookUrl = request.FacebookUrl;
            values.InstagramUrl = request.InstagramUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
