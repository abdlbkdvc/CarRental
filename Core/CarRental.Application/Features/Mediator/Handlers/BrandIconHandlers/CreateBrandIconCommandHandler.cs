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
    public class CreateBrandIconCommandHandler : IRequestHandler<CreateBrandIconCommand>
    {
        private readonly IRepository<BrandIcon> _repository;

        public CreateBrandIconCommandHandler(IRepository<BrandIcon> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBrandIconCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new BrandIcon
            {
                PhotoUrl = request.PhotoUrl
            });
        }
    }
}
