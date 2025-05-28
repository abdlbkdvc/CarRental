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
    public class GetBanner2ListQueryHandler : IRequestHandler<GetBanner2ListQuery, List<GetBanner2ListQueryResult>>
    {
        private readonly IRepository<Banner2> _repository;

        public GetBanner2ListQueryHandler(IRepository<Banner2> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBanner2ListQueryResult>> Handle(GetBanner2ListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetBanner2ListQueryResult
            {
                Banner2ID = x.Banner2ID,
                Discount = x.Discount,
                Title = x.Title,
                Description = x.Description,
                PhotoUrl = x.PhotoUrl
            }).ToList();
        }
    }
}
