using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Entities
{
    public sealed class NurseShift : AuditableEntity
    {
        public int Id { get; set; }
        public int NurseId { get; set; }
        public DateOnly ShiftDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        //public string Ward { get; set; } = string.Empty;


        public int WardId { get; set; }
        public Ward Ward { get; set; } =default!;
        public Staff Nurse { get; set; } = default!;
    }
}
