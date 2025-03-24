using HMS.Domain.Abstractions;
using HMS.Domain.Entities;
using HMS.Domain.Enums;
using HMS.Domain.Errors;
using HMS.Domain.Repositories.Contract;
using Mapster;
using MediatR;

namespace HMS.Application.Features.Patients.Commands.Create
{
    public class CreatePatientCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreatePatientCommand, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<Result<int>> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            //if (!Enum.TryParse<Gender>(request.Gender, true, out var genderEnum))
            //    return Result.Failure<int>(PatientErrors.InvalidGender);

            var patient = request.Adapt<Patient>();

            //patient.Gender = genderEnum;

            await _unitOfWork.Repository<Patient>().AddAsync(patient, cancellationToken);

            var saveResult = await _unitOfWork.CompleteAsync(cancellationToken);

            if (saveResult <= 0)
                return Result.Failure<int>(PatientErrors.FailedToAdd);

            return Result.Success(patient.Id);

        }
    }
}
