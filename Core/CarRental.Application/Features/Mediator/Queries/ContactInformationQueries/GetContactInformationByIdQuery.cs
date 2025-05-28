using CarRental.Application.Features.Mediator.Results.ContactInformationResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Queries.ContactInformationQueries
{
    public class GetContactInformationByIdQuery : IRequest<GetContactInformationByIdQueryResult>
    {
        public int Id { get; set; }

        public GetContactInformationByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
