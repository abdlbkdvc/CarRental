using CarRental.Dto.CarDtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.Car
{
    public class CreateCarValidation : AbstractValidator<CreateCarDto>
    {
        //public string PhotoUrl { get; set; }
        //public string CarName { get; set; }
        //public DateTime CarReleaseDate { get; set; }
        //public string Transmission { get; set; }
        //public string Km { get; set; }
        //public decimal Price { get; set; }
        public CreateCarValidation()
        {
            RuleFor(x => x.PhotoUrl).NotEmpty().WithMessage("Fotoğraf Url Boş Geçilemez");
            RuleFor(x => x.CarName).NotEmpty().WithMessage("Araba Adı  Boş Geçilemez");
            RuleFor(x => x.CarReleaseDate).NotEmpty().WithMessage("Araba Çıkış Tarihi Boş Geçilemez");
            RuleFor(x => x.Transmission).NotEmpty().WithMessage("Araba Vites Türü Boş Geçilemez");
            RuleFor(x => x.Km).NotEmpty().WithMessage("Araba Km Boş Geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Araba Fiyat Boş Geçilemez");

        }
    }
}
