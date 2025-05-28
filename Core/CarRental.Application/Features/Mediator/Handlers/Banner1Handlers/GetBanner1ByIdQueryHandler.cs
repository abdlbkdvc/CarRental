using CarRental.Application.Features.Mediator.Queries.Banner1Queries;
using CarRental.Application.Features.Mediator.Results.Banner1Results;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.Banner1Handlers
{
    public class GetBanner1ByIdQueryHandler : IRequestHandler<GetBanner1ByIdQuery, GetBanner1ByIdQueryResult>
    {
        private readonly IRepository<Banner1> _repository;

        public GetBanner1ByIdQueryHandler(IRepository<Banner1> repository)
        {
            _repository = repository;
        }

        public async Task<GetBanner1ByIdQueryResult> Handle(GetBanner1ByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetBanner1ByIdQueryResult
            {
                Banner1ID = value.Banner1ID,
                ImageUrl1 = value.ImageUrl1,
                ImageUrl2= value.ImageUrl2,
                Title = value.Title
            };
        }
    }
}
