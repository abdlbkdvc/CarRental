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
    public class GetAboutListQueryHandler : IRequestHandler<GetAboutListQuery, List<GetAboutListQueryResult>>
    {
        private readonly IRepository<About> _repository;

        public GetAboutListQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAboutListQueryResult>> Handle(GetAboutListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetAboutListQueryResult
            {
                AboutID = x.AboutID,
                Title = x.Title,
                ImageUrl = x.ImageUrl,
                Description = x.Description,
                IconUrl1 = x.IconUrl1,
                IconTitle1 = x.IconTitle1,
                IconUrl2 = x.IconUrl2,
                IconTitle2 = x.IconTitle2,
                IconUrl3 = x.IconUrl3,
                IconTitle3 = x.IconTitle3
            }).ToList();
        }
    }
}
