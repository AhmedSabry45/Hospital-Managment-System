using HMS.Domain.Abstractions;
using MediatR;

namespace HMS.Application.Features.Patients.Queries.GetAll
{
    public class GetAllPatientsQuery : IRequest<Result<IReadOnlyList<PatientResponse>>> { }
}