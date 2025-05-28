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
    public class CreateInformationCommandHandler : IRequestHandler<CreateInformationCommand>
    {
        private readonly IRepository<Information> _repository;

        public CreateInformationCommandHandler(IRepository<Information> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateInformationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Information
            {
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                FacebookUrl = request.FacebookUrl,
                TwitterUrl = request.TwitterUrl,
                LinkedInUrl = request.LinkedInUrl,
                InstagramUrl = request.InstagramUrl,
                YoutubeUrl = request.YoutubeUrl
            });
        }
    }
}
