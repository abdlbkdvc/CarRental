using CarRental.Application.Features.Mediator.Results.CarDetailResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Queries.CarDetailQueries
{
    public class GetCarDetailListQuery : IRequest<List<GetCarDetailListQueryResult>>
    {
    }
}
