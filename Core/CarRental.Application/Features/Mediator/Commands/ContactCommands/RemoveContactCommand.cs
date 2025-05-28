using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Commands.ContactCommands
{
    public class RemoveContactCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveContactCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
