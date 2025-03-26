using HMS.Domain.Entities;
using HMS.Domain.Errors;

namespace HMS.Application.Features.Insurance.Commands.Create
{
    public class CreateInsuranceCategoryCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreateInsuranceCategoryCommand, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<Result<int>> Handle(CreateInsuranceCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = request.Adapt<InsuranceCategory>();

            await _unitOfWork.Repository<InsuranceCategory>().AddAsync(category, cancellationToken);

            var saveResult = await _unitOfWork.CompleteAsync(cancellationToken);

            if (saveResult <= 0)
                return Result.Failure<int>(InsuranceErrors.FailedToAdd);

            return Result.Success(category.Id);

        }
    }
}
