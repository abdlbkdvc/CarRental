using CarRental.Dto.FooterAddressDtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.FooterAddress
{
    public class UpdateFooterAddressValidation : AbstractValidator<UpdateFooterAddressDto>
    {
        //public string Location { get; set; }
        //public string PhoneNumber { get; set; }
        //public string Email { get; set; }
        //public string TwitterUrl { get; set; }
        //public string FacebookUrl { get; set; }
        //public string LinkedInUrl { get; set; }
        //public string InstagramUrl { get; set; }
        //public string CarGalleryPhotoUrl1 { get; set; }
        //public string CarGalleryPhotoUrl2 { get; set; }
        //public string CarGalleryPhotoUrl3 { get; set; }
        //public string CarGalleryPhotoUrl4 { get; set; }
        //public string CarGalleryPhotoUrl5 { get; set; }
        //public string CarGalleryPhotoUrl6 { get; set; }
        public UpdateFooterAddressValidation()
        {
            RuleFor(x => x.Location).NotEmpty().WithMessage("İkon Url  Boş Geçilemez");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon No  Boş Geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email  Boş Geçilemez");
            RuleFor(x => x.TwitterUrl).NotEmpty().WithMessage("Twitter Url  Boş Geçilemez");
            RuleFor(x => x.FacebookUrl).NotEmpty().WithMessage("Facebook Url  Boş Geçilemez");
            RuleFor(x => x.LinkedInUrl).NotEmpty().WithMessage("LinkedIn Url  Boş Geçilemez");
            RuleFor(x => x.InstagramUrl).NotEmpty().WithMessage("Instagram Url  Boş Geçilemez");
            RuleFor(x => x.CarGalleryPhotoUrl1).NotEmpty().WithMessage("Araba Galeri Fotoğraf 1  Boş Geçilemez");
            RuleFor(x => x.CarGalleryPhotoUrl2).NotEmpty().WithMessage("Araba Galeri Fotoğraf 2  Boş Geçilemez");
            RuleFor(x => x.CarGalleryPhotoUrl3).NotEmpty().WithMessage("Araba Galeri Fotoğraf 3  Boş Geçilemez");
            RuleFor(x => x.CarGalleryPhotoUrl4).NotEmpty().WithMessage("Araba Galeri Fotoğraf 4  Boş Geçilemez");
            RuleFor(x => x.CarGalleryPhotoUrl5).NotEmpty().WithMessage("Araba Galeri Fotoğraf 5  Boş Geçilemez");
            RuleFor(x => x.CarGalleryPhotoUrl6).NotEmpty().WithMessage("Araba Galeri Fotoğraf 6  Boş Geçilemez");
        }
    }
}
