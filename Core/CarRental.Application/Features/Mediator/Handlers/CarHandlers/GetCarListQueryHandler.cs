using CarRental.Application.Features.Mediator.Queries.CarQueries;
using CarRental.Application.Features.Mediator.Results.CarResults;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.CarHandlers
{
    public class GetCarListQueryHandler : IRequestHandler<GetCarListQuery, List<GetCarListQueryResult>>
    {
        private readonly IRepository<Car> _repository;

        public GetCarListQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarListQueryResult>> Handle(GetCarListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetCarListQueryResult
            {
                CarID = x.CarID,
                CarName = x.CarName,
                CarReleaseDate = x.CarReleaseDate,
                Km = x.Km,
                PhotoUrl = x.PhotoUrl,
                Price = x.Price,
                Transmission = x.Transmission
            }).ToList();
        }
    }
}
