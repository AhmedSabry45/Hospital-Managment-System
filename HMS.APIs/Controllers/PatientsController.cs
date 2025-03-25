using HMS.Application.Features.Patients.Commands.Create;
using HMS.Application.Features.Patients.Commands.Delete;
using HMS.Application.Features.Patients.Commands.Update;
using HMS.Application.Features.Patients.Queries.Get;
using HMS.Application.Features.Patients.Queries.GetAll;
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

        [HttpGet("")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllPatientsQuery(), cancellationToken);
            return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetPatientByIdQuery(id), cancellationToken);
            return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
        }

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

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdatePatientCommand command, CancellationToken cancellationToken)
        {
            command.Id = id;

            var result = await _mediator.Send(command, cancellationToken);

            return result.IsSuccess ? NoContent() : result.ToProblem();
        }
    }
}
