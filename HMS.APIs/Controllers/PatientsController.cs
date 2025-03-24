using HMS.Application.Features.Patients.Commands.Create;
using HMS.Application.Features.Patients.Commands.Delete;
using HMS.Domain.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HMS.APIs.Controllers
{
    [Authorize]
    public class PatientsController(IMediator mediator) : ApiBaseController
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost("")]
        public async Task<IActionResult> Create([FromBody] CreatePatientCommand command, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(command, cancellationToken);

            return result.IsSuccess ? Created() : result.ToProblem();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] int Id, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new DeletePatientCommand(Id), cancellationToken);

            return result.IsSuccess ? NoContent() : result.ToProblem();

        }
    }
}
