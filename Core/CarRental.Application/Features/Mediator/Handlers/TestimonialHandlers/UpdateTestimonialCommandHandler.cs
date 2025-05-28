using CarRental.Application.Features.Mediator.Commands.TestimonialCommands;
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
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;

        public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.TestimonialID);
            values.PhotoUrl = request.PhotoUrl;
            values.ClientName = request.ClientName;
            values.ClientJob = request.ClientJob;
            values.ClientComment = request.ClientComment;
            values.TestimonialID = request.TestimonialID;
            await _repository.UpdateAsync(values);
        }
    }
}
