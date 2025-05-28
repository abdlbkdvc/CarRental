using CarRental.Application.Features.Mediator.Results.Banner1Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Queries.Banner1Queries
{
    public class GetBanner1ListQuery : IRequest<List<GetBanner1ListQueryResult>>
    {
    }
}
