using CarRental.Application.Features.Mediator.Results.Banner2Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Queries.Banner2Queries
{
    public class GetBanner2ListQuery : IRequest<List<GetBanner2ListQueryResult>>
    {
    }
}
