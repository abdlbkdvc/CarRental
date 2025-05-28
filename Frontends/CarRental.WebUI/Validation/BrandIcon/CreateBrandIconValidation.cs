using CarRental.Dto.BrandIconDtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.BrandIcon
{
    public class CreateBrandIconValidation : AbstractValidator<CreateBrandIconDto>
    {
        public CreateBrandIconValidation()
        {

            RuleFor(x => x.PhotoUrl).NotEmpty().WithMessage("Fotoğraf Url Boş Geçilemez");
        }
    }
}
