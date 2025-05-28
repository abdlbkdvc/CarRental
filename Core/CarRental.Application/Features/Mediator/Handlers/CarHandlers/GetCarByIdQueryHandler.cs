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
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, GetCarByIdQueryResult>
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetCarByIdQueryResult
            {
                CarID = values.CarID,
                CarName = values.CarName,
                CarReleaseDate = values.CarReleaseDate,
                Km = values.Km,
                PhotoUrl = values.PhotoUrl,
                Price = values.Price,
                Transmission = values.Transmission
            };
        }
    }
}
