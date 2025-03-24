using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure._Data.Configurations
{
    public class NurseActivityConfiguration : IEntityTypeConfiguration<NurseActivity>
    {
        public void Configure(EntityTypeBuilder<NurseActivity> builder)
        {
            builder.Property(na => na.ActivityDate)
               .IsRequired();

            builder.Property(na => na.ActivityDescription)
                   .IsRequired()
                   .HasMaxLength(500);
        }
    }
}
