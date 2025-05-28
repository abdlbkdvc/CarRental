using CarRental.Dto.CarDtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.Car
{
    public class UpdateCarValidation : AbstractValidator<UpdateCarDto>
    {
        public UpdateCarValidation()
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
