using CarRental.Application.Features.Mediator.Commands.Banner1Commands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.Banner1Handlers
{
    public class CreateBanner1CommandHandler : IRequestHandler<CreateBanner1Command>
    {
        private readonly IRepository<Banner1> _repository;

        public CreateBanner1CommandHandler(IRepository<Banner1> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBanner1Command request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Banner1
            {
                ImageUrl1 = request.ImageUrl1,
                ImageUrl2 = request.ImageUrl2,
                Title = request.Title
            });
        }
    }
}
