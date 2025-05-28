using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Results.AboutResults
{
    public class GetAboutListQueryResult
    {
        public int    AboutID { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string IconUrl1 { get; set; }
        public string IconTitle1 { get; set; }
        public string IconUrl2 { get; set; }
        public string IconTitle2 { get; set; }
        public string IconUrl3 { get; set; }
        public string IconTitle3 { get; set; }
    }
}
