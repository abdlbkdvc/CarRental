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
    public class CreateTeamMemberCommandHandler : IRequestHandler<CreateTeamMemberCommand>
    {
        private readonly IRepository<TeamMember> _repository;

        public CreateTeamMemberCommandHandler(IRepository<TeamMember> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTeamMemberCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new TeamMember
            {
                PhotoUrl = request.PhotoUrl,
                MemberName = request.MemberName,
                MemberJob = request.MemberJob,
                MemberIsActive = request.MemberIsActive,
                TwitterUrl = request.TwitterUrl,
                FacebookUrl = request.FacebookUrl,
                InstagramUrl = request.InstagramUrl
            });

        }
    }
}
