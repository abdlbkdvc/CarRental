﻿using CarRental.Application.Features.Mediator.Results.InformationResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Queries.InformationQueries
{
    public class GetInformationListQuery : IRequest<List<GetInformationListQueryResult>>
    {
    }
}
