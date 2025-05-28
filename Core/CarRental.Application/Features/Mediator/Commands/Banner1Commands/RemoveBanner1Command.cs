using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Commands.Banner1Commands
{
    public class RemoveBanner1Command : IRequest
    {
        public int Id { get; set; }

        public RemoveBanner1Command(int ıd)
        {
            Id = ıd;
        }
    }
}
