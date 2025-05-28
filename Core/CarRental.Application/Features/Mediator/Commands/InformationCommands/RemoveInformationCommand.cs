using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Commands.InformationCommands
{
    public class RemoveInformationCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveInformationCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
