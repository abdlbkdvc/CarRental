using CarRental.Dto.ContactInformationDtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.ContactInformation
{
    public class UpdateContactInformationValidation : AbstractValidator<UpdateContactInformationDto>
    {
        //public string IconUrl { get; set; }
        //public string Title { get; set; }
        //public string Address { get; set; }
        public UpdateContactInformationValidation()
        {
            RuleFor(x => x.IconUrl).NotEmpty().WithMessage("İkon Url  Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık  Boş Geçilemez");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres  Boş Geçilemez");
        }
    }
}
