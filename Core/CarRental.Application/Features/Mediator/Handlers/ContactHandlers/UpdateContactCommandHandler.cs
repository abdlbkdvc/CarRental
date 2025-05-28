using CarRental.Application.Features.Mediator.Commands.ContactCommands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand>
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ContactID);
            values.Email = request.Email;
            values.Subject = request.Subject;
            values.Name = request.Name;
            values.ContactID = request.ContactID;
            values.Message = request.Message;
            await _repository.UpdateAsync(values);
        }
    }
}
