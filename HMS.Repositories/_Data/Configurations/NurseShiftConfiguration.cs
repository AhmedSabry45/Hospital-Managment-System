using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure._Data.Configurations
{
    public class NurseShiftConfiguration : IEntityTypeConfiguration<NurseShift>
    {
        public void Configure(EntityTypeBuilder<NurseShift> builder)
        {
            builder.Property(ns => ns.ShiftDate)
              .IsRequired();

            builder.Property(ns => ns.StartTime)
                   .IsRequired();

            builder.Property(ns => ns.EndTime)
                   .IsRequired();
        }
    }
}
