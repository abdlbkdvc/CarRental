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
    public class RemoveBanner3CommandHandler : IRequestHandler<RemoveBanner3Command>
    {
        private readonly IRepository<Banner3> _repository;

        public RemoveBanner3CommandHandler(IRepository<Banner3> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBanner3Command request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(values);
        }
    }
}
