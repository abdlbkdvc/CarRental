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
    public class UpdateBanner1CommandHandler : IRequestHandler<UpdateBanner1Command>
    {
        private readonly IRepository<Banner1> _repository;

        public UpdateBanner1CommandHandler(IRepository<Banner1> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBanner1Command request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Banner1ID);
            values.Banner1ID = request.Banner1ID;
            values.Title = request.Title;
            values.ImageUrl1 = request.ImageUrl1;
            values.ImageUrl2 = request.ImageUrl2;
            await _repository.UpdateAsync(values);
        }
    }
}
