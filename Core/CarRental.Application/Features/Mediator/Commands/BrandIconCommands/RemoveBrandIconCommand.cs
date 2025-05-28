using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Commands.BrandIconCommands
{
    public class RemoveBrandIconCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveBrandIconCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
