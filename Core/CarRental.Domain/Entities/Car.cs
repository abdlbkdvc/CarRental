using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        public string PhotoUrl { get; set; }
        public string CarName { get; set; }
        public DateTime CarReleaseDate { get; set; }
        public string Transmission { get; set; }
        public string Km { get; set; }
        public decimal Price { get; set; }
    }
}
