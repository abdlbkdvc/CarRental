using CarRental.Application.Features.Mediator.Results.Banner3Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Queries.Banner3Queries
{
    public class GetBanner3ByIdQuery : IRequest<GetBanner3ByIdQueryResult>
    {
        public int Id { get; set; }

        public GetBanner3ByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
