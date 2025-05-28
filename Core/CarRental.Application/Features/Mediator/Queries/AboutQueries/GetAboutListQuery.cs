﻿using CarRental.Application.Features.Mediator.Results.AboutResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Queries.AboutQueries
{
    public class GetAboutListQuery : IRequest<List<GetAboutListQueryResult>>
    {
    }
}
