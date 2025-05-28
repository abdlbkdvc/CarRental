using CarRental.Dto.TeamMemberDtos;
using FluentValidation;

namespace CarRental.WebUI.Validation.TeamMember
{
    public class CreateTeamMemberValidation : AbstractValidator<CreateTeamMemberDto>
    {
        //public string PhotoUrl { get; set; }
        //public string MemberName { get; set; }
        //public string MemberJob { get; set; }
        //public bool MemberIsActive { get; set; }
        //public string TwitterUrl { get; set; }
        //public string FacebookUrl { get; set; }
        //public string InstagramUrl { get; set; }
        public CreateTeamMemberValidation()
        {
            RuleFor(x => x.PhotoUrl).NotEmpty().WithMessage("Fotoğraf Url Boş Geçilemez");
            RuleFor(x => x.MemberName).NotEmpty().WithMessage("Üye Adı Boş Geçilemez");
            RuleFor(x => x.MemberJob).NotEmpty().WithMessage("Üye Meslek Boş Geçilemez");
            RuleFor(x => x.MemberIsActive).NotEmpty().WithMessage("Üye Aktifliği Boş Geçilemez");
            RuleFor(x => x.TwitterUrl).NotEmpty().WithMessage("Twitter Url Boş Geçilemez");
            RuleFor(x => x.FacebookUrl).NotEmpty().WithMessage("Facebook Url Boş Geçilemez");
            RuleFor(x => x.InstagramUrl).NotEmpty().WithMessage("Instagram Url Boş Geçilemez");

        }
    }
}
