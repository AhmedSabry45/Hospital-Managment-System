using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Entities
{
    public sealed class DoctorPerformance : AuditableEntity
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public DateOnly EvaluationDate { get; set; }
        public decimal Rating { get; set; }
        public string Comments { get; set; } = string.Empty;
        public int EvaluatedBy { get; set; } 


        public Staff Doctor { get; set; } = default!;
        public Staff Evaluator { get; set; } = default!;
    }
}
