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
    public class GetFooterAddressListQueryHandler : IRequestHandler<GetFooterAddressListQuery, List<GetFooterAddressListQueryResult>>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressListQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressListQueryResult>> Handle(GetFooterAddressListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetFooterAddressListQueryResult
            {
                Location = x.Location,
                PhoneNumber = x.PhoneNumber,
                Email = x.Email,
                TwitterUrl = x.TwitterUrl,
                FacebookUrl = x.FacebookUrl,
                LinkedInUrl = x.LinkedInUrl,
                InstagramUrl = x.InstagramUrl,
                CarGalleryPhotoUrl1 = x.CarGalleryPhotoUrl1,
                CarGalleryPhotoUrl2 = x.CarGalleryPhotoUrl2,
                CarGalleryPhotoUrl3 = x.CarGalleryPhotoUrl3,
                CarGalleryPhotoUrl4 = x.CarGalleryPhotoUrl4,
                CarGalleryPhotoUrl5 = x.CarGalleryPhotoUrl5,
                CarGalleryPhotoUrl6 = x.CarGalleryPhotoUrl6
            }).ToList();
        }
    }
}
