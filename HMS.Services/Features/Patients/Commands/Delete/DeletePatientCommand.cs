using HMS.Domain.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Patients.Commands.Delete
{
    public sealed class DeletePatientCommand(int id) : IRequest<Result>
    {
        public int Id { get; } = id;
    }
}
