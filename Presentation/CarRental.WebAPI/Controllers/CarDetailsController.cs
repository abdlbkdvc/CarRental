using CarRental.Application.Features.Mediator.Commands.AboutCommands;
using CarRental.Application.Features.Mediator.Commands.CarDetailCommands;
using CarRental.Application.Features.Mediator.Queries.AboutQueries;
using CarRental.Application.Features.Mediator.Queries.CarDetailQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDetailsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarDetailsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCarDetailList()
        {
            var result = await _mediator.Send(new GetCarDetailListQuery());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarDetailById(int id)
        {
            var result = await _mediator.Send(new GetCarDetailByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCarDetail(CreateCarDetailCommand command)
        {
            await _mediator.Send(command);
            return Ok("Araba Detayları Oluşturuldu.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCarDetail(UpdateCarDetailCommand command)
        {
            await _mediator.Send(command);
            return Ok("Araba Detayları Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCarDetail(int id)
        {
            await _mediator.Send(new RemoveCarDetailCommand(id));
            return Ok("Araba Detayları Silindi.");
        }
    }
}
