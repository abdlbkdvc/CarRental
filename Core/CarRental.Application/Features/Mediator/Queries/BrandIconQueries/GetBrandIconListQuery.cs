using CarRental.Application.Features.Mediator.Results.BrandIconResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Queries.BrandIconQueries
{
    public class GetBrandIconListQuery : IRequest<List<GetBrandIconListQueryResult>>
    {
    }
}
