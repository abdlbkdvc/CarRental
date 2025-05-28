using CarRental.Application.Features.Mediator.Commands.CarDetailCommands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.CarDetailHandlers
{
    public class CreateCarDetailCommandHandler : IRequestHandler<CreateCarDetailCommand>
    {
        private readonly IRepository<CarDetail> _repository;

        public CreateCarDetailCommandHandler(IRepository<CarDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarDetailCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new CarDetail
            {
                CarName = request.CarName,
                GalleryPhoto1 = request.GalleryPhoto1,
                GalleryPhoto2 = request.GalleryPhoto2,
                GalleryPhoto3 = request.GalleryPhoto3,
                GalleryPhoto4 = request.GalleryPhoto4,
                Description = request.Description
            });
        }
    }
}
