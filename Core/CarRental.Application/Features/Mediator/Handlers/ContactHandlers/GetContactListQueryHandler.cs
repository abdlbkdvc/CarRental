using CarRental.Application.Features.Mediator.Queries.ContactQueries;
using CarRental.Application.Features.Mediator.Results.ContactResults;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.ContactHandlers
{
    public class GetContactListQueryHandler : IRequestHandler<GetContactListQuery, List<GetContactListQueryResult>>
    {
        private readonly IRepository<Contact> _repository;

        public GetContactListQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetContactListQueryResult>> Handle(GetContactListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetContactListQueryResult
            {
                ContactID = x.ContactID,
                Email = x.Email,
                Message = x.Message,
                Name = x.Name,
                Subject = x.Subject
            }).ToList();
        }
    }
}
