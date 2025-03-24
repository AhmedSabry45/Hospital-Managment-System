using HMS.Domain.Enums;

namespace HMS.Domain.Entities
{
    public sealed class Patient : AuditableEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; } 
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string EmergencyPhone { get; set; } = string.Empty;
        public string EmergencyContact { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;
        public string Nationality { get; set; } = string.Empty;
        public string? NationalId { get; set; }

        public int? InsuranceCompanyId { get; set; } 
        public int? InsuranceCategoryId { get; set; } 
        public string? InsuranceNumber { get; set; }

        public InsuranceCompany? InsuranceCompany { get; set; }
        public InsuranceCategory? InsuranceCategory { get; set; }
    }
}
