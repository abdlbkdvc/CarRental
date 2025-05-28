using CarRental.Application.Features.Mediator.Commands.ServiceCommands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public UpdateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ServiceID);
            values.ServiceTitle = request.ServiceTitle;
            values.IconUrl = request.IconUrl;
            values.IconTitle = request.IconTitle;
            values.IconDescription = request.IconDescription;
            values.ServiceID = request.ServiceID;
            await _repository.UpdateAsync(values);
        }
    }
}
