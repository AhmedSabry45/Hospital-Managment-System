using HMS.Domain.Enums;

namespace HMS.Infrastructure._Data.Configurations
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.Property(s => s.FullName)
               .IsRequired()
               .HasMaxLength(350);

            builder.Property(s => s.Email)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.Property(s => s.Specialization)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(s => s.PhoneNumber)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(s => s.HireDate)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(s=>s.Status)
                .HasMaxLength(100);
        }
    }
}
