using CarRental.Application.Features.Mediator.Queries.AboutQueries;
using CarRental.Application.Features.Mediator.Results.AboutResults;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler : IRequestHandler<GetAboutByIdQuery, GetAboutByIdQueryResult>
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetAboutByIdQueryResult
            {
                AboutID = values.AboutID,
                Title = values.Title,
                ImageUrl = values.ImageUrl,
                Description = values.Description,
                IconUrl1 = values.IconUrl1,
                IconTitle1 = values.IconTitle1,
                IconUrl2 = values.IconUrl2,
                IconTitle2 = values.IconTitle2,
                IconUrl3 = values.IconUrl3,
                IconTitle3 = values.IconTitle3
            };
        }
    }
}
