using CarRental.Application.Features.Mediator.Queries.Banner3Queries;
using CarRental.Application.Features.Mediator.Results.Banner3Results;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.Banner3Handlers
{
    public class GetBanner3ListQueryHandler : IRequestHandler<GetBanner3ListQuery, List<GetBanner3ListQueryResult>>
    {
        private readonly IRepository<Banner3> _repository;

        public GetBanner3ListQueryHandler(IRepository<Banner3> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBanner3ListQueryResult>> Handle(GetBanner3ListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetBanner3ListQueryResult
            {
                Banner3ID = x.Banner3ID,
                PhotoUrl = x.PhotoUrl,
                Title = x.Title,
                Description = x.Description
            }).ToList();
        }
    }
}
