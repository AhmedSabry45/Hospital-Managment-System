using HMS.Application.Features.Patients.Queries.GetAll;
using HMS.Domain.Errors;
using HMS.Domain.Specifications.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Patients.Queries.Get
{
    public class GetPatientByIdQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetPatientByIdQuery, Result<PatientResponse>>
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<Result<PatientResponse>> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
        {
            var spec = new PatientSpecification(request.Id);

            var patient = await _unitOfWork.Repository<Patient>().GetByIdWithSpecAsync(spec);

            if (patient == null)
                return Result.Failure<PatientResponse>(PatientErrors.PatientNotFounded);

            var response = patient.Adapt<PatientResponse>();

            return Result.Success(response);
        }
    }
}
