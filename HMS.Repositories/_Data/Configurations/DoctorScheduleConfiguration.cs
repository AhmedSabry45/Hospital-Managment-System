using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure._Data.Configurations
{
    public class DoctorScheduleConfiguration : IEntityTypeConfiguration<DoctorSchedule>
    {
        public void Configure(EntityTypeBuilder<DoctorSchedule> builder)
        {
            builder.Property(ds => ds.WeekDay)
               .IsRequired();

            builder.Property(ds => ds.StartTime)
                   .IsRequired();

            builder.Property(ds => ds.EndTime)
                   .IsRequired();
        }
    }
}
