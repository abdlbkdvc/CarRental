using CarRental.Dto.Banner3Dtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.Banner3
{
    public class UpdateBanner3Validation : AbstractValidator<UpdateBanner3Dto>
    {
        public UpdateBanner3Validation()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.PhotoUrl).NotEmpty().WithMessage("Fotoğraf Url Boş Geçilemez");
        }
    }
}
