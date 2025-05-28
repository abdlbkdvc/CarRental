using CarRental.Application.Features.Mediator.Commands.CarCommands;
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
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand>
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Car
            {
                PhotoUrl = request.PhotoUrl,
                CarName = request.CarName,
                CarReleaseDate = request.CarReleaseDate,
                Transmission = request.Transmission,
                Km = request.Km,
                Price = request.Price
            });

        }
    }
}
