using CarRental.Dto.BrandIconDtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.BrandIcon
{
    public class UpdateBrandIconValidation : AbstractValidator<UpdateBrandIconDto>
    {
        public UpdateBrandIconValidation()
        {
            RuleFor(x => x.PhotoUrl).NotEmpty().WithMessage("Fotoğraf Url Boş Geçilemez");

        }
    }
}
