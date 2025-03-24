using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Entities
{
    public sealed class Admission : AuditableEntity
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int BedId { get; set; }
      
        public DateTime? DischargeDateTime { get; set; } 
        public string DiagnosisOnAdmission { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        public Patient Patient { get; set; } = default!;
        public Bed Bed { get; set; } = default!;
    }
}
