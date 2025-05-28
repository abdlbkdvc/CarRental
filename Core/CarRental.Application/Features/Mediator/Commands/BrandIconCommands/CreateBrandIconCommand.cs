using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Commands.BrandIconCommands
{
    public class CreateBrandIconCommand : IRequest
    {
        public string PhotoUrl { get; set; }

    }
}
