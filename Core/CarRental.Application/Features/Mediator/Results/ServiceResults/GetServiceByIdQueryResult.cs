using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Results.ServiceResults
{
    public class GetServiceByIdQueryResult
    {
        public int ServiceID { get; set; }
        public string ServiceTitle { get; set; }
        public string IconUrl { get; set; }
        public string IconTitle { get; set; }
        public string IconDescription { get; set; }
    }
}
