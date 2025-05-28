using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Commands.ServiceCommands
{
    public class CreateServiceCommand : IRequest
    {
        public string ServiceTitle { get; set; }
        public string IconUrl { get; set; }
        public string IconTitle { get; set; }
        public string IconDescription { get; set; }
    }
}
