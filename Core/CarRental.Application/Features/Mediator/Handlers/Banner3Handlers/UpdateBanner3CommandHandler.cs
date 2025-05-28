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
    public class UpdateBanner3CommandHandler : IRequestHandler<UpdateBanner3Command>
    {
        private readonly IRepository<Banner3> _repository;

        public UpdateBanner3CommandHandler(IRepository<Banner3> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBanner3Command request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Banner3ID);
            values.Banner3ID = request.Banner3ID;
            values.PhotoUrl = request.PhotoUrl;
            values.Title = request.Title;
            values.Description = request.Description;
            await _repository.UpdateAsync(values);
        }
    }
}
