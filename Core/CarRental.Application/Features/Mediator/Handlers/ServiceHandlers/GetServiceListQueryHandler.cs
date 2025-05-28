using CarRental.Application.Features.Mediator.Queries.ServiceQueries;
using CarRental.Application.Features.Mediator.Results.ServiceResults;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceListQueryHandler : IRequestHandler<GetServiceListQuery, List<GetServiceListQueryResult>>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceListQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceListQueryResult>> Handle(GetServiceListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetServiceListQueryResult
            {
                IconDescription = x.IconDescription,
                IconTitle = x.IconTitle,
                IconUrl = x.IconUrl,
                ServiceID = x.ServiceID,
                ServiceTitle = x.ServiceTitle
            }).ToList();
        }
    }
}
