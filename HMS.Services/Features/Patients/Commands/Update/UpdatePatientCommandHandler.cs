using HMS.Domain.Abstractions;
using HMS.Domain.Entities;
using HMS.Domain.Errors;
using HMS.Domain.Repositories.Contract;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Patients.Commands.Update
{
    public class UpdatePatientCommandHandler : IRequestHandler<UpdatePatientCommand, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePatientCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<int>> Handle(UpdatePatientCommand request, CancellationToken cancellationToken)
        {
            var patient = await _unitOfWork.Repository<Patient>()
                .GetByIdAsync(request.Id, cancellationToken);

            if (patient == null)
                return Result.Failure<int>(PatientErrors.PatientNotFounded);

            patient = request.Adapt(patient);

            _unitOfWork.Repository<Patient>().Update(patient);

            var saveResult = await _unitOfWork.CompleteAsync(cancellationToken);

            if (saveResult <= 0)
                return Result.Failure<int>(PatientErrors.FailedToUpdate);

            return Result.Success(patient.Id);
        }
    }
}
