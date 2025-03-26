using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Insurance.Queries.GetAll
{
    class GetAllInsuranceCompaniesQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetAllInsuranceCompaniesQuery, Result<IReadOnlyList<InsuranceResponse>>>
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<Result<IReadOnlyList<InsuranceResponse>>> Handle(GetAllInsuranceCompaniesQuery request, CancellationToken cancellationToken)
        {
            var insurances = await _unitOfWork.Repository<InsuranceCompany>().GetAllAsync(cancellationToken);

            var response = insurances.Select(i => i.Adapt<InsuranceResponse>()).ToList().AsReadOnly();

            return Result.Success<IReadOnlyList<InsuranceResponse>>(response);
        }
    }
}
