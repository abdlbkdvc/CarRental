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
    public class UpdateContactInformationCommandHandler : IRequestHandler<UpdateContactInformationCommand>
    {
        private readonly IRepository<ContactInformation> _repository;

        public UpdateContactInformationCommandHandler(IRepository<ContactInformation> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactInformationCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ContactID);
            values.Title = request.Title;
            values.IconUrl = request.IconUrl;
            values.Address = request.Address;
            values.ContactID = request.ContactID;
            await _repository.UpdateAsync(values);
        }
    }
}
