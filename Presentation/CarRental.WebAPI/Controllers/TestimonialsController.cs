using CarRental.Application.Features.Mediator.Commands.AboutCommands;
using CarRental.Application.Features.Mediator.Commands.TestimonialCommands;
using CarRental.Application.Features.Mediator.Queries.AboutQueries;
using CarRental.Application.Features.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestimonialsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTestimonialList()
        {
            var result = await _mediator.Send(new GetTestimonialListQuery());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonialById(int id)
        {
            var result = await _mediator.Send(new GetTestimonialByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
        {
            await _mediator.Send(command);
            return Ok("Testimonial Oluşturuldu.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
        {
            await _mediator.Send(command);
            return Ok("Testimonial Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _mediator.Send(new RemoveTestimonialCommand(id));
            return Ok("Testimonial Silindi.");
        }
    }
}
