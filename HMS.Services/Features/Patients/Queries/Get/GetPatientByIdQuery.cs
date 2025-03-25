using HMS.Application.Features.Patients.Queries.GetAll;

namespace HMS.Application.Features.Patients.Queries.Get
{
    public class GetPatientByIdQuery(int id) : IRequest<Result<PatientResponse>>
    {
        public int Id { get; set; } = id;
    }
}
