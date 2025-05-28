using CarRental.Dto.ContactDtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.Contact
{
    public class CreateContactValidation : AbstractValidator<CreateContactDto>
    {
        //public string Name { get; set; }
        //public string Email { get; set; }
        //public string Subject { get; set; }
        //public string Message { get; set; }
        public CreateContactValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim  Boş Geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email  Boş Geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu  Boş Geçilemez");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj  Boş Geçilemez");

        }
    }
}
