using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Commands.Banner3Commands
{
    public class CreateBanner3Command : IRequest
    {
        public string PhotoUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
