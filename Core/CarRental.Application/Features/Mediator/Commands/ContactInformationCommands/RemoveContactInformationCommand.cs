using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Commands.ContactInformationCommands
{
    public class RemoveContactInformationCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveContactInformationCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
