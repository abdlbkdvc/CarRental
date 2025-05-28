using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities
{
    public class BrandIcon
    {
        [Key]
        public int BrandIconID { get; set; }
        public string PhotoUrl { get; set; }
    }
}
