using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class UpdateFooterAddressCommand : IRequest
    {
        public int FooterAddressID { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string TwitterUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string CarGalleryPhotoUrl1 { get; set; }
        public string CarGalleryPhotoUrl2 { get; set; }
        public string CarGalleryPhotoUrl3 { get; set; }
        public string CarGalleryPhotoUrl4 { get; set; }
        public string CarGalleryPhotoUrl5 { get; set; }
        public string CarGalleryPhotoUrl6 { get; set; }
    }
}
