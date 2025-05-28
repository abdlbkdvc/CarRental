﻿using CarRental.Application.Features.Mediator.Results.FooterAddressResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressListQuery : IRequest<List<GetFooterAddressListQueryResult>>
    {
    }
}
