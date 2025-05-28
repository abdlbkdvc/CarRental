using CarRental.Dto.Banner1Dtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.Banner1
{
    public class UpdateBanner1Validation : AbstractValidator<UpdateBanner1Dto>
    {
        public UpdateBanner1Validation()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.ImageUrl1).NotEmpty().WithMessage("Fotoğraf Url 1 Boş Geçilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Fotoğraf Url 2 Boş Geçilemez");
        }
    }
}
