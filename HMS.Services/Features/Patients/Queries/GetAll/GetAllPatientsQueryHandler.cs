using HMS.Domain.Specifications.Patients;

namespace HMS.Application.Features.Patients.Queries.GetAll
{
    class GetAllPatientsQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetAllPatientsQuery, Result<IReadOnlyList<PatientResponse>>>
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<Result<IReadOnlyList<PatientResponse>>> Handle(GetAllPatientsQuery request, CancellationToken cancellationToken)
        {

            var spec = new PatientSpecification();

            var patients = await _unitOfWork.Repository<Patient>().GetAllWithSpecAsync(spec, cancellationToken);

            var response = patients.Select(p => p.Adapt<PatientResponse>()).ToList().AsReadOnly();

            return Result.Success<IReadOnlyList<PatientResponse>>(response);
        }
    }
}
