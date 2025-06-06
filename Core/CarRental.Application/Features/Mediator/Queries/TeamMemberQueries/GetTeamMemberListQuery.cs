﻿using CarRental.Application.Features.Mediator.Results.TeamMemberResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Queries.TeamMemberQueries
{
    public class GetTeamMemberListQuery : IRequest<List<GetTeamMemberListQueryResult>>
    {
    }
}
