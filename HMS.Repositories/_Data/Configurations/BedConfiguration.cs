using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure._Data.Configurations
{
    public class BedConfiguration : IEntityTypeConfiguration<Bed>
    {
        public void Configure(EntityTypeBuilder<Bed> builder)
        {
            builder.Property(b => b.BedNumber)
               .IsRequired()
               .HasMaxLength(30);

            builder.Property(b => b.Status)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
