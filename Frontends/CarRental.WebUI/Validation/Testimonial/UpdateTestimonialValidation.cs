using CarRental.Dto.TestimonialDtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.Testimonial
{
    public class UpdateTestimonialValidation : AbstractValidator<UpdateTestimonialDto>
    {
        //public string PhotoUrl { get; set; }
        //public string ClientName { get; set; }
        //public string ClientJob { get; set; }
        //public string ClientComment { get; set; }
        public UpdateTestimonialValidation()
        {
            RuleFor(x => x.PhotoUrl).NotEmpty().WithMessage("Fotoğraf Url Boş Geçilemez");
            RuleFor(x => x.ClientName).NotEmpty().WithMessage("Müşteri Adı Boş Geçilemez");
            RuleFor(x => x.ClientJob).NotEmpty().WithMessage("Müşteri Meslek Boş Geçilemez");
            RuleFor(x => x.ClientComment).NotEmpty().WithMessage("Müşteri Yorum Boş Geçilemez");

        }
    }
}
