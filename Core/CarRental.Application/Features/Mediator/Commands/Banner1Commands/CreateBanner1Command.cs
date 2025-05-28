using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Commands.Banner1Commands
{
    public class CreateBanner1Command : IRequest
    {
        public string Title { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
    }
}
