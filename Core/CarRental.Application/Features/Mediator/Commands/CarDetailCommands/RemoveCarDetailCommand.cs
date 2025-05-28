using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Commands.CarDetailCommands
{
    public class RemoveCarDetailCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveCarDetailCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
