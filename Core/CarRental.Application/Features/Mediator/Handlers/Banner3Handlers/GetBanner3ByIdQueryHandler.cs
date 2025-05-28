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
    public class GetBanner3ByIdQueryHandler : IRequestHandler<GetBanner3ByIdQuery, GetBanner3ByIdQueryResult>
    {
        private readonly IRepository<Banner3> _repository;

        public GetBanner3ByIdQueryHandler(IRepository<Banner3> repository)
        {
            _repository = repository;
        }

        public async Task<GetBanner3ByIdQueryResult> Handle(GetBanner3ByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetBanner3ByIdQueryResult
            {
                Banner3ID = values.Banner3ID,
                PhotoUrl = values.PhotoUrl,
                Title = values.Title,
                Description = values.Description
            };
        }
    }
}
