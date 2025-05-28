using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Dto.ContactInformationDtos
{
    public class UpdateContactInformationDto
    {
        public int ContactID { get; set; }
        public string IconUrl { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
    }
}
