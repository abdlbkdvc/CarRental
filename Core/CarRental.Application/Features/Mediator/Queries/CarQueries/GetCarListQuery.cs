using CarRental.Application.Features.Mediator.Results.CarResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Queries.CarQueries
{
    public class GetCarListQuery : IRequest<List<GetCarListQueryResult>>
    {
    }
}
