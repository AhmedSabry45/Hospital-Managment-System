namespace HMS.Domain.Entities
{
    public sealed class StaffCategory : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<Staff> Staffs { get; set; } = new HashSet<Staff>();
    }
}