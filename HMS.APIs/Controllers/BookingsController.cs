using HMS.Application.Features.Bookings.Commands.Create;
using HMS.Domain.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HMS.APIs.Controllers
{
    [Authorize]
    public class BookingsController(IMediator mediator) : ApiBaseController
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost("rooms")]
        public async Task<IActionResult> Create([FromBody] CreateBookingCommand command, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(command, cancellationToken);

            return result.IsSuccess ? CreatedAtAction("",result.Value) : result.ToProblem();
        }
    }
}
