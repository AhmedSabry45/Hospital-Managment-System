using HMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Entities
{
    public sealed class Appointment : AuditableEntity
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public int StatusId { get; set; }
        public string? Notes { get; set; }
        public AppointmentStatus Status { get; set; }


        public Patient Patient { get; set; } = default!;
        public Staff Doctor { get; set; } = default!;
    }
}
