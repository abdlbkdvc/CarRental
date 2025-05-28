using CarRental.Application.Features.Mediator.Queries.TeamMemberQueries;
using CarRental.Application.Features.Mediator.Results.TeamMemberResults;
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
    public class GetTeamMemberByIdQueryHandler : IRequestHandler<GetTeamMemberByIdQuery, GetTeamMemberByIdQueryResult>
    {
        private readonly IRepository<TeamMember> _repository;

        public GetTeamMemberByIdQueryHandler(IRepository<TeamMember> repository)
        {
            _repository = repository;
        }

        public async Task<GetTeamMemberByIdQueryResult> Handle(GetTeamMemberByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetTeamMemberByIdQueryResult
            {
                PhotoUrl = values.PhotoUrl,
                MemberName = values.MemberName,
                MemberJob = values.MemberJob,
                MemberIsActive = values.MemberIsActive,
                TwitterUrl = values.TwitterUrl,
                FacebookUrl = values.FacebookUrl,
                InstagramUrl = values.InstagramUrl
            };
        }
    }
}
