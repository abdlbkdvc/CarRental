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
    public class CreateFooterAddressCommandHandler : IRequestHandler<CreateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public CreateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new FooterAddress
            {
                Location = request.Location,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                TwitterUrl = request.TwitterUrl,
                FacebookUrl = request.FacebookUrl,
                LinkedInUrl = request.LinkedInUrl,
                InstagramUrl = request.InstagramUrl,
                CarGalleryPhotoUrl1 = request.CarGalleryPhotoUrl1,
                CarGalleryPhotoUrl2 = request.CarGalleryPhotoUrl2,
                CarGalleryPhotoUrl3 = request.CarGalleryPhotoUrl3,
                CarGalleryPhotoUrl4 = request.CarGalleryPhotoUrl4,
                CarGalleryPhotoUrl5 = request.CarGalleryPhotoUrl5,
                CarGalleryPhotoUrl6 = request.CarGalleryPhotoUrl6
            });
        }
    }
}
