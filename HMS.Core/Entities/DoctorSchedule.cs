using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Entities
{
    public sealed class DoctorSchedule : AuditableEntity
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int WeekDay { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }


        public Staff Doctor { get; set; } = default!;
    }
}
