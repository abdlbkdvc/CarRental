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
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand>
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.CarID);
            values.Transmission = request.Transmission;
            values.CarID = request.CarID;
            values.CarName = request.CarName;
            values.CarReleaseDate = request.CarReleaseDate;
            values.Km = request.Km;
            values.PhotoUrl = request.PhotoUrl;
            values.Price = request.Price;
            await _repository.UpdateAsync(values);
        }
    }
}
