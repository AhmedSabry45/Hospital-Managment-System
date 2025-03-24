using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure._Data.Configurations
{
    public class InsuranceCategoryConfiguration : IEntityTypeConfiguration<InsuranceCategory>
    {
        public void Configure(EntityTypeBuilder<InsuranceCategory> builder)
        {
            builder.Property(i => i.Name).IsRequired()
                  .HasMaxLength(500);
        }
    }
}
