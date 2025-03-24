namespace HMS.Domain.Entities
{
    public sealed class Bed : AuditableEntity
    {
        public int Id { get; set; }
        public int WardId { get; set; }
        public string BedNumber { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        public Ward Ward { get; set; } = default!;
    }
}