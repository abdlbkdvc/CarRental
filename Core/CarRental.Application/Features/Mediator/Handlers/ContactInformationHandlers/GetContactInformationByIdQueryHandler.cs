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
    public class GetContactInformationByIdQueryHandler : IRequestHandler<GetContactInformationByIdQuery, GetContactInformationByIdQueryResult>
    {
        private readonly IRepository<ContactInformation> _repository;

        public GetContactInformationByIdQueryHandler(IRepository<ContactInformation> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactInformationByIdQueryResult> Handle(GetContactInformationByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetContactInformationByIdQueryResult
            {
                ContactID = values.ContactID,
                IconUrl = values.IconUrl,
                Title = values.Title,
                Address = values.Address
            };
        }
    }
}
