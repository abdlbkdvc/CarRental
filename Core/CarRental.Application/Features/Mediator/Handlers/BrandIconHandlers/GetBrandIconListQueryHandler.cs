using CarRental.Application.Features.Mediator.Queries.BrandIconQueries;
using CarRental.Application.Features.Mediator.Results.BrandIconResults;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.BrandIconHandlers
{
    public class GetBrandIconListQueryHandler : IRequestHandler<GetBrandIconListQuery, List<GetBrandIconListQueryResult>>
    {
        private readonly IRepository<BrandIcon> _repository;

        public GetBrandIconListQueryHandler(IRepository<BrandIcon> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBrandIconListQueryResult>> Handle(GetBrandIconListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetBrandIconListQueryResult
            {
                BrandIconID = x.BrandIconID,
                PhotoUrl = x.PhotoUrl
            }).ToList();
        }
    }
}
