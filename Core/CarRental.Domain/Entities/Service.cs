using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }
        public string ServiceTitle { get; set; }
        public string IconUrl { get; set; }
        public string IconTitle { get; set; }
        public string IconDescription { get; set; }
    }
}
