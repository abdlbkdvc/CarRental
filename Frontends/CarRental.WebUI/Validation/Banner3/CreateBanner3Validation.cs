using CarRental.Dto.Banner3Dtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.Banner3
{
    public class CreateBanner3Validation:AbstractValidator<CreateBanner3Dto>
    {
        //public string PhotoUrl { get; set; }
        //public string Title { get; set; }
        //public string Description { get; set; }
        public CreateBanner3Validation()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.PhotoUrl).NotEmpty().WithMessage("Fotoğraf Url Boş Geçilemez");
        }
    }
}
