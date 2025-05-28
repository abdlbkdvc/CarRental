using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Dto.InformationDtos
{
    public class UpdateInformationDto
    {
        public int InformationID { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string YoutubeUrl { get; set; }
    }
}
