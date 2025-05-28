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
    public class GetCarDetailListQueryHandler : IRequestHandler<GetCarDetailListQuery, List<GetCarDetailListQueryResult>>
    {
        private readonly IRepository<CarDetail> _repository;

        public GetCarDetailListQueryHandler(IRepository<CarDetail> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarDetailListQueryResult>> Handle(GetCarDetailListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetCarDetailListQueryResult
            {
                CarName = x.CarName,
                GalleryPhoto1 = x.GalleryPhoto1,
                GalleryPhoto2 = x.GalleryPhoto2,
                GalleryPhoto3 = x.GalleryPhoto3,
                GalleryPhoto4 = x.GalleryPhoto4,
                Description = x.Description
            }).ToList();
        }
    }
}
