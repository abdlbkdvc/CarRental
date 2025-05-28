using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities
{
    public class Banner1
    {
        [Key]
        public int Banner1ID { get; set; }
        public string Title { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }

    }
}
