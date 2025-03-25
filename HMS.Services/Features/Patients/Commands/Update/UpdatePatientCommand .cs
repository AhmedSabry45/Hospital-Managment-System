using HMS.Domain.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Patients.Commands.Update
{
    public class UpdatePatientCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; }
        public string EmergencyPhone { get; set; }
        public string EmergencyContact { get; set; }
        public string Nationality { get; set; }
        public string? NationalId { get; set; }

        public int? InsuranceCompanyId { get; set; }
        public int? InsuranceCategoryId { get; set; }
        public string? InsuranceNumber { get; set; }
    }
}
