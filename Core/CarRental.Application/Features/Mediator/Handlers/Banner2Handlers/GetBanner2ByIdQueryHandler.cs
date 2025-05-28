using CarRental.Application.Features.Mediator.Queries.Banner2Queries;
using CarRental.Application.Features.Mediator.Results.Banner2Results;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.Banner2Handlers
{
    public class GetBanner2ByIdQueryHandler : IRequestHandler<GetBanner2ByIdQuery, GetBanner2ByIdQueryResult>
    {
        private readonly IRepository<Banner2> _repository;

        public GetBanner2ByIdQueryHandler(IRepository<Banner2> repository)
        {
            _repository = repository;
        }

        public async Task<GetBanner2ByIdQueryResult> Handle(GetBanner2ByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetBanner2ByIdQueryResult
            {
                Banner2ID = value.Banner2ID,
                Discount = value.Discount,
                Title = value.Title,
                Description = value.Description,
                PhotoUrl = value.PhotoUrl
            };
        }
    }
}
