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
    public class UpdateInformationCommandHandler : IRequestHandler<UpdateInformationCommand>
    {
        private readonly IRepository<Information> _repository;

        public UpdateInformationCommandHandler(IRepository<Information> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateInformationCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.InformationID);
            values.InformationID = request.InformationID;
            values.PhoneNumber = request.PhoneNumber;
            values.Email = request.Email;
            values.FacebookUrl = request.FacebookUrl;
            values.TwitterUrl = request.TwitterUrl;
            values.LinkedInUrl = request.LinkedInUrl;
            values.InstagramUrl = request.InstagramUrl;
            values.YoutubeUrl = request.YoutubeUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
