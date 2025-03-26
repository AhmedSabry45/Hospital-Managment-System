using HMS.Domain.Errors;

namespace HMS.Application.Features.Insurance.Commands.Create
{
    public class CreateInsuranceCompanyCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreateInsuranceCompanyCommand, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<Result<int>> Handle(CreateInsuranceCompanyCommand request, CancellationToken cancellationToken)
        {
            var company = request.Adapt<InsuranceCompany>();

            await _unitOfWork.Repository<InsuranceCompany>().AddAsync(company, cancellationToken);

            var saveResult = await _unitOfWork.CompleteAsync(cancellationToken);

            if (saveResult <= 0)
                return Result.Failure<int>(InsuranceErrors.FailedToAdd);

            return Result.Success(company.Id);

        }
    }
}
