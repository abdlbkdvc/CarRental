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
    public class UpdateBanner2CommandHandler : IRequestHandler<UpdateBanner2Command>
    {
        private readonly IRepository<Banner2> _repository;

        public UpdateBanner2CommandHandler(IRepository<Banner2> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBanner2Command request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Banner2ID);
            values.Banner2ID = request.Banner2ID;
            values.Description = request.Description;
            values.Discount = request.Discount;
            values.PhotoUrl = request.PhotoUrl;
            values.Title = request.Title;
            await _repository.UpdateAsync(values);
        }
    }
}
