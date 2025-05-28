using CarRental.Dto.InformationDtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.Information
{
    public class CreateInformationValidation : AbstractValidator<CreateInformationDto>
    {
        //public string PhoneNumber { get; set; }
        //public string Email { get; set; }
        //public string FacebookUrl { get; set; }
        //public string TwitterUrl { get; set; }
        //public string LinkedInUrl { get; set; }
        //public string InstagramUrl { get; set; }
        //public string YoutubeUrl { get; set; }
        public CreateInformationValidation()
        {
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon No  Boş Geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email  Boş Geçilemez");
            RuleFor(x => x.FacebookUrl).NotEmpty().WithMessage("Facebook Url  Boş Geçilemez");
            RuleFor(x => x.TwitterUrl).NotEmpty().WithMessage("Twitter Url  Boş Geçilemez");
            RuleFor(x => x.LinkedInUrl).NotEmpty().WithMessage("LinkedIn Url  Boş Geçilemez");
            RuleFor(x => x.InstagramUrl).NotEmpty().WithMessage("Instagram Url  Boş Geçilemez");
            RuleFor(x => x.YoutubeUrl).NotEmpty().WithMessage("Youtube Url  Boş Geçilemez");

        }
    }
}
