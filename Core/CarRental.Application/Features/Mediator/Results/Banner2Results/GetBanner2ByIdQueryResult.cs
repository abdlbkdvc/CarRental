using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Results.Banner2Results
{
    public class GetBanner2ByIdQueryResult
    {
        public int    Banner2ID { get; set; }
        public string Discount { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
    }
}
