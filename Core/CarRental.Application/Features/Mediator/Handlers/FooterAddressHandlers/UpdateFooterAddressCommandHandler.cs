using CarRental.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.FooterAddressID);
            values.Location = request.Location;
            values.PhoneNumber = request.PhoneNumber;
            values.Email = request.Email;
            values.TwitterUrl = request.TwitterUrl;
            values.FacebookUrl = request.FacebookUrl;
            values.LinkedInUrl = request.LinkedInUrl;
            values.InstagramUrl = request.InstagramUrl;
            values.CarGalleryPhotoUrl1 = request.CarGalleryPhotoUrl1;
            values.CarGalleryPhotoUrl2 = request.CarGalleryPhotoUrl2;
            values.CarGalleryPhotoUrl3 = request.CarGalleryPhotoUrl3;
            values.CarGalleryPhotoUrl4 = request.CarGalleryPhotoUrl4;
            values.CarGalleryPhotoUrl5 = request.CarGalleryPhotoUrl5;
            values.CarGalleryPhotoUrl6 = request.CarGalleryPhotoUrl6;
            await _repository.UpdateAsync(values);
        }
    }
}
