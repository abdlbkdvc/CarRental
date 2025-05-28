using CarRental.Application.Features.Mediator.Queries.TestimonialQueries;
using CarRental.Application.Features.Mediator.Results.TestimonialResults;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialListQueryHandler : IRequestHandler<GetTestimonialListQuery, List<GetTestimonialListQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialListQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialListQueryResult>> Handle(GetTestimonialListQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllListAsync();
            return values.Select(x => new GetTestimonialListQueryResult
            {
                ClientComment = x.ClientComment,
                ClientJob = x.ClientJob,
                ClientName = x.ClientName,
                PhotoUrl = x.PhotoUrl,
                TestimonialID = x.TestimonialID
            }).ToList();
        }
    }
}
