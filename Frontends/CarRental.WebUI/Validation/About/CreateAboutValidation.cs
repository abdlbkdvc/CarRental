using CarRental.Dto.AboutDtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.About
{
    public class CreateAboutValidation : AbstractValidator<CreateAboutDto>
    {
        public CreateAboutValidation()
        {
            RuleFor(x=>x.IconTitle1).NotEmpty().WithMessage("İkon başlığı 1 boş geçilemez.");
            RuleFor(x => x.IconTitle2).NotEmpty().WithMessage("İkon başlığı 2 boş geçilemez.");
            RuleFor(x => x.IconTitle3).NotEmpty().WithMessage("İkon başlığı 3 boş geçilemez.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim URL'si boş geçilemez.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş geçilemez.");
            RuleFor(x => x.IconUrl1).NotEmpty().WithMessage("İkon URL 1 boş geçilemez.");
            RuleFor(x => x.IconUrl2).NotEmpty().WithMessage("İkon URL 2 boş geçilemez.");
            RuleFor(x => x.IconUrl3).NotEmpty().WithMessage("İkon URL 3 boş geçilemez.");

        }
    }
}
