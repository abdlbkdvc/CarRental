using CarRental.Dto.Banner1Dtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.Banner1
{
    public class CreateBanner1Validation : AbstractValidator<CreateBanner1Dto>
    {
        public CreateBanner1Validation()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.ImageUrl1).NotEmpty().WithMessage("Fotoğraf Url 1 Boş Geçilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Fotoğraf Url 2 Boş Geçilemez");
        }
    }
}
