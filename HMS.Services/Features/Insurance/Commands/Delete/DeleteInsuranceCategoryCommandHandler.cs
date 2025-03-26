using HMS.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Insurance.Commands.Delete
{
    public class DeleteInsuranceCategoryCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<DeleteInsuranceCategoryCommand, Result>
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<Result> Handle(DeleteInsuranceCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _unitOfWork.Repository<InsuranceCategory>().GetByIdAsync(request.Id, cancellationToken);

            if (category == null)
                return Result.Failure(InsuranceErrors.InsuranceNotFounded);


            category.IsActive = false;

            await _unitOfWork.CompleteAsync(cancellationToken);

            return Result.Success();

        }
    }
}
