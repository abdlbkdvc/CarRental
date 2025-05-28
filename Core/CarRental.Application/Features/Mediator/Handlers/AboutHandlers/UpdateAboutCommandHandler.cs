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
    public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommand>
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AboutID);
            values.Title = request.Title;
            values.ImageUrl = request.ImageUrl;
            values.Description = request.Description;
            values.IconUrl1 = request.IconUrl1;
            values.IconTitle1 = request.IconTitle1;
            values.IconUrl2 = request.IconUrl2;
            values.IconTitle2 = request.IconTitle2;
            values.IconUrl3 = request.IconUrl3;
            values.IconTitle3 = request.IconTitle3;
            await _repository.UpdateAsync(values);

        }
    }
}
