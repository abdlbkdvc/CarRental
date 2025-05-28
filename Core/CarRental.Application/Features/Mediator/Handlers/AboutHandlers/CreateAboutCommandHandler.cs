using CarRental.Application.Features.Mediator.Commands.AboutCommands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommand>
    {
        private readonly IRepository<About> _repository;

        public CreateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new About
            {
                Title        = request.Title,
                ImageUrl      = request.ImageUrl,
                Description   = request.Description,
                IconUrl1     = request.IconUrl1,
                IconTitle1    = request.IconTitle1,
                IconUrl2      = request.IconUrl2,
                IconTitle2      = request.IconTitle2,
                IconUrl3      = request.IconUrl3,
                IconTitle3      = request.IconTitle3

            });
        }
    }
}
