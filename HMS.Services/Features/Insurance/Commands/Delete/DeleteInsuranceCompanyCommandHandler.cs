using HMS.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Insurance.Commands.Delete
{
    public class DeleteInsuranceCompanyCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<DeleteInsuranceCompanyCommand, Result>
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<Result> Handle(DeleteInsuranceCompanyCommand request, CancellationToken cancellationToken)
        {
            var company = await _unitOfWork.Repository<InsuranceCompany>().GetByIdAsync(request.Id, cancellationToken);

            if (company == null)
                return Result.Failure(InsuranceErrors.InsuranceNotFounded);

            company.IsActive = false;

            await _unitOfWork.CompleteAsync(cancellationToken);

            return Result.Success();
        }
    }
}
