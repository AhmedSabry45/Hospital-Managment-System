using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Entities
{
    public sealed class NurseActivity : AuditableEntity
    {
        public int Id { get; set; }
        public int NurseId { get; set; }
        public int PatientId { get; set; }
        public DateTime ActivityDate { get; set; }
        public string ActivityDescription { get; set; } = string.Empty;

        
        public Staff Nurse { get; set; } = default!;
        public Patient Patient { get; set; } = default!;
    }
}
