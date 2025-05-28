using CarRental.Application.Features.Mediator.Commands.BrandIconCommands;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.BrandIconHandlers
{
    public class RemoveBrandIconCommandHandler : IRequestHandler<RemoveBrandIconCommand>
    {
        private readonly IRepository<BrandIcon> _repository;

        public RemoveBrandIconCommandHandler(IRepository<BrandIcon> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBrandIconCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(values);
        }
    }
}
