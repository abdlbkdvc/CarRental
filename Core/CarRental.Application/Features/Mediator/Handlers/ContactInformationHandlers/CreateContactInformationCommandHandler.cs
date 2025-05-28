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
    public class CreateContactInformationCommandHandler : IRequestHandler<CreateContactInformationCommand>
    {
        private readonly IRepository<ContactInformation> _repository;

        public CreateContactInformationCommandHandler(IRepository<ContactInformation> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateContactInformationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ContactInformation
            {
                IconUrl = request.IconUrl,
                Title   = request.Title,
                Address = request.Address
            });
        }
    }
}
