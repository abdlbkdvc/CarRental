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
    public class GetTeamMemberListQueryHandler : IRequestHandler<GetTeamMemberListQuery, List<GetTeamMemberListQueryResult>>
    {
        private readonly IRepository<TeamMember> _repository;

        public GetTeamMemberListQueryHandler(IRepository<TeamMember> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTeamMemberListQueryResult>> Handle(GetTeamMemberListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetTeamMemberListQueryResult
            {
                PhotoUrl = x.PhotoUrl,
                MemberName = x.MemberName,
                MemberJob = x.MemberJob,
                MemberIsActive = x.MemberIsActive,
                TwitterUrl = x.TwitterUrl,
                FacebookUrl = x.FacebookUrl,
                InstagramUrl = x.InstagramUrl
            }).ToList();
        }
    }
}
