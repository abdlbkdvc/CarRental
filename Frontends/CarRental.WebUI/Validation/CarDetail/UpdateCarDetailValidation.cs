using CarRental.Dto.CarDetailDtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.CarDetail
{
    public class UpdateCarDetailValidation : AbstractValidator<UpdateCarDetailDto>
    {//public string CarName { get; set; }
        //public string GalleryPhoto1 { get; set; }
        //public string GalleryPhoto2 { get; set; }
        //public string GalleryPhoto3 { get; set; }
        //public string GalleryPhoto4 { get; set; }
        //public string Description { get; set; }
        public UpdateCarDetailValidation()
        {
            RuleFor(x => x.CarName).NotEmpty().WithMessage("Araba Adı  Boş Geçilemez");
            RuleFor(x => x.GalleryPhoto1).NotEmpty().WithMessage("Galeri Fotoğraf 1 Boş Geçilemez");
            RuleFor(x => x.GalleryPhoto1).NotEmpty().WithMessage("Galeri Fotoğraf 1 Boş Geçilemez");
            RuleFor(x => x.GalleryPhoto1).NotEmpty().WithMessage("Galeri Fotoğraf 1 Boş Geçilemez");
            RuleFor(x => x.GalleryPhoto1).NotEmpty().WithMessage("Galeri Fotoğraf 1 Boş Geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Geçilemez");
        }
    }
}
