using CarRental.Application.Features.Mediator.Queries.FooterAddressQueries;
using CarRental.Application.Features.Mediator.Results.FooterAddressResults;
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
    public class GetFooterAddressByIdQueryHandler : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResult>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetFooterAddressByIdQueryResult
            {
                Location = values.Location,
                PhoneNumber = values.PhoneNumber,
                Email = values.Email,
                TwitterUrl = values.TwitterUrl,
                FacebookUrl = values.FacebookUrl,
                LinkedInUrl = values.LinkedInUrl,
                InstagramUrl = values.InstagramUrl,
                CarGalleryPhotoUrl1 = values.CarGalleryPhotoUrl1,
                CarGalleryPhotoUrl2 = values.CarGalleryPhotoUrl2,
                CarGalleryPhotoUrl3 = values.CarGalleryPhotoUrl3,
                CarGalleryPhotoUrl4 = values.CarGalleryPhotoUrl4,
                CarGalleryPhotoUrl5 = values.CarGalleryPhotoUrl5,
                CarGalleryPhotoUrl6 = values.CarGalleryPhotoUrl6
            };
        }
    }
}
