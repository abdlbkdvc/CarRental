using CarRental.Application.Features.Mediator.Queries.CarDetailQueries;
using CarRental.Application.Features.Mediator.Results.CarDetailResults;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.CarDetailHandlers
{
    public class GetCarDetailByIdQueryHandler : IRequestHandler<GetCarDetailByIdQuery, GetCarDetailByIdQueryResult>
    {
        private readonly IRepository<CarDetail> _repository;

        public GetCarDetailByIdQueryHandler(IRepository<CarDetail> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarDetailByIdQueryResult> Handle(GetCarDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetCarDetailByIdQueryResult
            {
                CarName = values.CarName,
                GalleryPhoto1 = values.GalleryPhoto1,
                GalleryPhoto2 = values.GalleryPhoto2,
                GalleryPhoto3 = values.GalleryPhoto3,
                GalleryPhoto4 = values.GalleryPhoto4,
                Description = values.Description
            };
        }
    }
}
