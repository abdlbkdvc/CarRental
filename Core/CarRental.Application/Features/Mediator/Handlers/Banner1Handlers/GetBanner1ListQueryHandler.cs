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
    public class GetBanner1ListQueryHandler : IRequestHandler<GetBanner1ListQuery, List<GetBanner1ListQueryResult>>
    {
        private readonly IRepository<Banner1> _repository;

        public GetBanner1ListQueryHandler(IRepository<Banner1> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBanner1ListQueryResult>> Handle(GetBanner1ListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetBanner1ListQueryResult
            {
                Banner1ID = x.Banner1ID,
                ImageUrl1 = x.ImageUrl1,
                ImageUrl2 = x.ImageUrl2,
                Title = x.Title
            }).ToList();
        }
    }
}
