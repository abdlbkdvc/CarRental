using CarRental.Application.Features.Mediator.Commands.CarDetailCommands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.CarDetailHandlers
{
    public class RemoveCarDetailCommandHandler : IRequestHandler<RemoveCarDetailCommand>
    {
        private readonly IRepository<CarDetail> _repository;

        public RemoveCarDetailCommandHandler(IRepository<CarDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCarDetailCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(values);
        }
    }
}
