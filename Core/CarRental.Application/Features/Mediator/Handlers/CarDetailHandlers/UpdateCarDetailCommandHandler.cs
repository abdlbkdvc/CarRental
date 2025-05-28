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
    public class UpdateCarDetailCommandHandler : IRequestHandler<UpdateCarDetailCommand>
    {
        private readonly IRepository<CarDetail> _repository;

        public UpdateCarDetailCommandHandler(IRepository<CarDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarDetailCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.CarDetailID);
            values.Description = request.Description;
            values.CarName = request.CarName;
            values.CarDetailID = request.CarDetailID;
            values.GalleryPhoto1 = request.GalleryPhoto1;
            values.GalleryPhoto2 = request.GalleryPhoto2;
            values.GalleryPhoto3 = request.GalleryPhoto3;
            values.GalleryPhoto4 = request.GalleryPhoto4;
            await _repository.UpdateAsync(values);
        }
    }
}
