using CarRental.Application.Features.Mediator.Commands.ContactInformationCommands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.ContactInformationHandlers
{
    public class RemoveContactInformationCommandHandler : IRequestHandler<RemoveContactInformationCommand>
    {
        private readonly IRepository<ContactInformation> _repository;

        public RemoveContactInformationCommandHandler(IRepository<ContactInformation> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveContactInformationCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(values);
        }
    }
}
