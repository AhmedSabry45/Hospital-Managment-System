using HMS.Domain.Enums;

namespace HMS.Domain.Entities
{
    public sealed class Room : AuditableEntity
    {
        public int Id { get; set; }
        public int Number { get; set; } 
        public RoomType Type { get; set; }
        public RoomStatus Status { get; set; } = RoomStatus.Available;


        public ICollection<Bed> Beds { get; set; } = new HashSet<Bed>();
    }
}