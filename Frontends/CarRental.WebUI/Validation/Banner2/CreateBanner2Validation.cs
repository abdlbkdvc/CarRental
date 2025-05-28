using CarRental.Dto.Banner2Dtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.Banner2
{
    public class CreateBanner2Validation : AbstractValidator<CreateBanner2Dto>
    {
        //public string Discount { get; set; }
        //public string Title { get; set; }
        //public string Description { get; set; }
        //public string PhotoUrl { get; set; }
        public CreateBanner2Validation()
        {
            RuleFor(x => x.Discount).NotEmpty().WithMessage("İndirim Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.PhotoUrl).NotEmpty().WithMessage("Fotoğraf Url Boş Geçilemez");
        }
    }
}
