using CarRental.Application.Features.Mediator.Commands.ContactCommands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarRental.Application.Features.Mediator.Handlers.ContactHandlers
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand>
    {
        private readonly IRepository<Contact> _repository;

        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Contact
            {
                Name = request.Name,
                Email = request.Email,
                Subject = request.Subject,
                Message = request.Message
            });
        }
    }
}
