using CarRental.Application.Features.Mediator.Queries.InformationQueries;
using CarRental.Application.Features.Mediator.Results.InformationResults;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.InformationHandlers
{
    public class GetInformationListQueryHandler : IRequestHandler<GetInformationListQuery, List<GetInformationListQueryResult>>
    {
        private readonly IRepository<Information> _repository;

        public GetInformationListQueryHandler(IRepository<Information> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetInformationListQueryResult>> Handle(GetInformationListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetInformationListQueryResult
            {
                Email = x.Email,
                FacebookUrl = x.FacebookUrl,
                InformationID = x.InformationID,
                InstagramUrl = x.InstagramUrl,
                PhoneNumber = x.PhoneNumber,
                TwitterUrl = x.TwitterUrl,
                LinkedInUrl = x.LinkedInUrl,
                YoutubeUrl = x.YoutubeUrl
            }).ToList();
        }
    }
}
