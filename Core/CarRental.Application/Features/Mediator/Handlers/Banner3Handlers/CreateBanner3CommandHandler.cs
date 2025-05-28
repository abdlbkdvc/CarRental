using CarRental.Application.Features.Mediator.Commands.Banner3Commands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.Banner3Handlers
{
    public class CreateBanner3CommandHandler : IRequestHandler<CreateBanner3Command>
    {
        private readonly IRepository<Banner3> _repository;

        public CreateBanner3CommandHandler(IRepository<Banner3> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBanner3Command request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Banner3
            {
                PhotoUrl = request.PhotoUrl,
                Title = request.Title,
                Description = request.Description
            });
        }
    }
}
