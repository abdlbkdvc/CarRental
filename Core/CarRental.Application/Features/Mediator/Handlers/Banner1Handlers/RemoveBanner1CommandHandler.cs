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
    public class RemoveBanner1CommandHandler : IRequestHandler<RemoveBanner1Command>
    {
        private readonly IRepository<Banner1> _repository;

        public RemoveBanner1CommandHandler(IRepository<Banner1> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBanner1Command request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
