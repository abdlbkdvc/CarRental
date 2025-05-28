using CarRental.Dto.Banner2Dtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.Banner2
{
    public class UpdateBanner2Validation : AbstractValidator<UpdateBanner2Dto>
    {
        public UpdateBanner2Validation()
        {
            RuleFor(x => x.Discount).NotEmpty().WithMessage("İndirim Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.PhotoUrl).NotEmpty().WithMessage("Fotoğraf Url Boş Geçilemez");
        }
    }
}
