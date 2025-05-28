using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Commands.Banner2Commands
{
    public class RemoveBanner2Command : IRequest
    {
        public int Id { get; set; }

        public RemoveBanner2Command(int ıd)
        {
            Id = ıd;
        }
    }
}
