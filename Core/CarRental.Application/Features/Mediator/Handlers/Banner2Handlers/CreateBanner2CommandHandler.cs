using CarRental.Application.Features.Mediator.Commands.Banner2Commands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.Banner2Handlers
{
    public class CreateBanner2CommandHandler : IRequestHandler<CreateBanner2Command>
    {
        private readonly IRepository<Banner2> _repository;

        public CreateBanner2CommandHandler(IRepository<Banner2> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBanner2Command request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Banner2
            {
                Discount = request.Discount,
                Title = request.Title,
                Description = request.Description,
                PhotoUrl = request.PhotoUrl
            });
        }
    }
}
