﻿using CarRental.Application.Features.Mediator.Results.ContactInformationResults;
using CarRental.Application.Features.Mediator.Results.ContactResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Queries.ContactQueries
{
    public class GetContactListQuery : IRequest<List<GetContactListQueryResult>>
    {
    }
}
