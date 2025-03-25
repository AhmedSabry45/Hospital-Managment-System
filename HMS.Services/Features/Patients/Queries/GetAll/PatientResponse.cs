using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Patients.Queries.GetAll
{
    public class PatientResponse
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string EmergencyPhone { get; set; }
        public string EmergencyContact { get; set; }
        public string Nationality { get; set; }
        public string? NationalId { get; set; }

        public int? InsuranceCompanyId { get; set; }
        public string? InsuranceCompanyName { get; set; }
        public int? InsuranceCategoryId { get; set; }
        public string? InsuranceCategoryName { get; set; }
        public string? InsuranceNumber { get; set; }
    }
}
