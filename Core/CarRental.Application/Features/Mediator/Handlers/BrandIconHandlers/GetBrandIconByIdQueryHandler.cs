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
    public class GetBrandIconByIdQueryHandler : IRequestHandler<GetBrandIconByIdQuery, GetBrandIconByIdQueryResult>
    {
        private readonly IRepository<BrandIcon> _repository;

        public GetBrandIconByIdQueryHandler(IRepository<BrandIcon> repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandIconByIdQueryResult> Handle(GetBrandIconByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetBrandIconByIdQueryResult
            {
                BrandIconID = values.BrandIconID,
                PhotoUrl = values.PhotoUrl
            };
        }
    }
}
