using CarRental.Application.Features.Mediator.Commands.InformationCommands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.InformationHandlers
{
    public class RemoveInformationCommandHandler : IRequestHandler<RemoveInformationCommand>
    {
        private readonly IRepository<Information> _repository;

        public RemoveInformationCommandHandler(IRepository<Information> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveInformationCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(values);
        }
    }
}
