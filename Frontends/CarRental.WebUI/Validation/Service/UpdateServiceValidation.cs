using CarRental.Dto.ServiceDtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.Service
{
    public class UpdateServiceValidation : AbstractValidator<UpdateServiceDto>
    {
        //public string ServiceTitle { get; set; }
        //public string IconUrl { get; set; }
        //public string IconTitle { get; set; }
        //public string IconDescription { get; set; }
        public UpdateServiceValidation()
        {
            RuleFor(x => x.ServiceTitle).NotEmpty().WithMessage("Servis Başlığı Boş Geçilemez");
            RuleFor(x => x.IconUrl).NotEmpty().WithMessage("İkon Url Boş Geçilemez");
            RuleFor(x => x.IconTitle).NotEmpty().WithMessage("İkon Başlık Boş Geçilemez");
            RuleFor(x => x.IconDescription).NotEmpty().WithMessage("İkon Açıklama Boş Geçilemez");

        }
    }
}
