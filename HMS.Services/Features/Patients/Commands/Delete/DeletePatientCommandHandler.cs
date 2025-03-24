using HMS.Domain.Abstractions;
using HMS.Domain.Entities;
using HMS.Domain.Errors;
using HMS.Domain.Repositories.Contract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Patients.Commands.Delete
{
    public class DeletePatientCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<DeletePatientCommand, Result>
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<Result> Handle(DeletePatientCommand request, CancellationToken cancellationToken)
        {
            var patient = await _unitOfWork.Repository<Patient>().GetByIdAsync(request.Id, cancellationToken);

            if (patient is null)
                return Result.Failure(PatientErrors.PatientNotFounded);

            patient.IsActive = false;

            await _unitOfWork.CompleteAsync(cancellationToken);

            return Result.Success();
        }
    }
}
