using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Dto.TestimonialDtos
{
    public class UpdateTestimonialDto
    {
        public int TestimonialID { get; set; }
        public string PhotoUrl { get; set; }
        public string ClientName { get; set; }
        public string ClientJob { get; set; }
        public string ClientComment { get; set; }
    }
}
