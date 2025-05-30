﻿using CarRental.Application.Features.Mediator.Queries.ServiceQueries;
using CarRental.Application.Features.Mediator.Results.ServiceResults;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                IconDescription = values.IconDescription,
                IconTitle = values.IconTitle,
                IconUrl = values.IconUrl,
                ServiceID = values.ServiceID,
                ServiceTitle = values.ServiceTitle                
            };
        }
    }
}
