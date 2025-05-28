using CarRental.Application.Features.Mediator.Results.CarDetailResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Queries.CarDetailQueries
{
    public class GetCarDetailByIdQuery : IRequest<GetCarDetailByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCarDetailByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
