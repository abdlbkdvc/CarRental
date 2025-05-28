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
    public class GetInformationByIdQueryHandler : IRequestHandler<GetInformationByIdQuery, GetInformationByIdQueryResult>
    {
        private readonly IRepository<Information> _repository;

        public GetInformationByIdQueryHandler(IRepository<Information> repository)
        {
            _repository = repository;
        }

        public async Task<GetInformationByIdQueryResult> Handle(GetInformationByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetInformationByIdQueryResult
            {
                Email = values.Email,
                FacebookUrl = values.FacebookUrl,
                InformationID = values.InformationID,
                InstagramUrl = values.InstagramUrl,
                LinkedInUrl = values.LinkedInUrl,
                PhoneNumber = values.PhoneNumber,
                TwitterUrl = values.TwitterUrl,
                YoutubeUrl = values.YoutubeUrl
            };
        }
    }
}
