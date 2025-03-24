namespace HMS.Infrastructure._Data.Configurations
{
    public class StaffCategoryConfiguration : IEntityTypeConfiguration<StaffCategory>
    {
        public void Configure(EntityTypeBuilder<StaffCategory> builder)
        {
            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
