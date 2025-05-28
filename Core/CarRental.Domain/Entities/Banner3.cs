using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities
{
    public class Banner3
    {
        [Key]
        public int    Banner3ID { get; set; }
        public string PhotoUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
