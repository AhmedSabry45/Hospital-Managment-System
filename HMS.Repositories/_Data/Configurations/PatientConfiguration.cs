using HMS.Domain.Enums;

namespace HMS.Infrastructure._Data.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.Property(p=> p.FullName)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(p => p.DateOfBirth)
                   .IsRequired()
                   .HasColumnType("date");

            builder.Property(p => p.Gender)
                     .HasConversion(
                     (type) => type.ToString(),
                     (gen) => Enum.Parse<Gender>(gen, true)).HasMaxLength(55);

            builder.Property(p => p.Phone)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(p => p.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Address)
                   .HasMaxLength(255);

            builder.Property(p => p.EmergencyPhone)
                   .HasMaxLength(20);

            builder.Property(p => p.EmergencyContact)
                   .HasMaxLength(250);
        }
    }
}
