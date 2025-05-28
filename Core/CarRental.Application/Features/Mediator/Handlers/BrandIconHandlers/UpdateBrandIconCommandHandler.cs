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
    public class UpdateBrandIconCommandHandler : IRequestHandler<UpdateBrandIconCommand>
    {
        private readonly IRepository<BrandIcon> _repository;

        public UpdateBrandIconCommandHandler(IRepository<BrandIcon> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBrandIconCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.BrandIconID);
            values.BrandIconID = request.BrandIconID;
            values.PhotoUrl = request.PhotoUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
