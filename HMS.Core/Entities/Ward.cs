using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Entities
{
    public sealed class Ward : AuditableEntity
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }

        public ICollection<Room> Rooms { get; set; } = new HashSet<Room>();
    }
}
