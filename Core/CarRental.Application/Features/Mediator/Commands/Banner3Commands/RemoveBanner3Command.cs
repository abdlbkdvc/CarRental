using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Commands.Banner3Commands
{
    public class RemoveBanner3Command : IRequest
    {
        public int Id { get; set; }

        public RemoveBanner3Command(int ıd)
        {
            Id = ıd;
        }
    }
}
