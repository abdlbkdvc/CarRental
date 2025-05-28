using CarRental.Application.Features.Mediator.Queries.ContactInformationQueries;
using CarRental.Application.Features.Mediator.Results.ContactInformationResults;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.ContactInformationHandlers
{
    public class GetContactInformationListQueryHandler : IRequestHandler<GetContactInformationListQuery, List<GetContactInformationListQueryResult>>
    {
        private readonly IRepository<ContactInformation> _repository;

        public GetContactInformationListQueryHandler(IRepository<ContactInformation> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetContactInformationListQueryResult>> Handle(GetContactInformationListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetContactInformationListQueryResult
            {
              ContactID = x.ContactID,
                IconUrl = x.IconUrl,
                Title = x.Title,
                Address = x.Address

            }).ToList();
        }
    }
}
