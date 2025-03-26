using HMS.Application.Features.Insurance.Commands.Create;
using HMS.Application.Features.Insurance.Commands.Delete;
using HMS.Application.Features.Insurance.Queries.GetAll;
using HMS.Domain.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HMS.APIs.Controllers
{
    [Authorize]
    public class InsuranceController(IMediator mediator) : ApiBaseController
    {
        private readonly IMediator _mediator = mediator;


        [HttpGet("categories")]
        public async Task<IActionResult> GetAllCategories(CancellationToken cancellationToken = default)
        {
            var result = await _mediator.Send(new GetAllInsuranceCategoriesQuery(), cancellationToken);

            return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
        }

        [HttpPost("categories")]
        public async Task<IActionResult> CreateCategory([FromBody] CreateInsuranceCategoryCommand command, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(command, cancellationToken);

            return result.IsSuccess ? Created("", result.Value) : result.ToProblem();
        }

        [HttpDelete("categories/{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new DeleteInsuranceCategoryCommand(id), cancellationToken);
            return result.IsSuccess ? NoContent() : result.ToProblem();
        }

        [HttpGet("companies")]
        public async Task<IActionResult> GetAllCompanies(CancellationToken cancellationToken = default)
        {
            var result = await _mediator.Send(new GetAllInsuranceCompaniesQuery(), cancellationToken);

            return result.IsSuccess ? Ok(result.Value) : result.ToProblem();
        }

        [HttpPost("companies")]
        public async Task<IActionResult> CreateCompany([FromBody] CreateInsuranceCompanyCommand command, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(command, cancellationToken);
            return result.IsSuccess ? Created("", result.Value) : result.ToProblem();
        }


        [HttpDelete("companies/{id}")]
        public async Task<IActionResult> DeleteCompany([FromRoute] int id, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new DeleteInsuranceCompanyCommand(id), cancellationToken);
            return result.IsSuccess ? NoContent() : result.ToProblem();
        }
    }
}
