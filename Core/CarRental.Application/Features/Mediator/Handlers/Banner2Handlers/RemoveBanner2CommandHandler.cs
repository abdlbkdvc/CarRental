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
    public class RemoveBanner2CommandHandler : IRequestHandler<RemoveBanner2Command>
    {
        private readonly IRepository<Banner2> _repository;

        public RemoveBanner2CommandHandler(IRepository<Banner2> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBanner2Command request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(values);
        }
    }
}
