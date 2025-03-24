using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure._Data.Configurations
{
    public class DoctorPerformanceConfiguration : IEntityTypeConfiguration<DoctorPerformance>
    {
        public void Configure(EntityTypeBuilder<DoctorPerformance> builder)
        {
            builder.Property(dp => dp.EvaluationDate)
               .IsRequired();

            builder.Property(dp => dp.Rating)
                   .HasColumnType("decimal(12,2)")
                   .IsRequired();

            builder.Property(dp => dp.Comments)
                   .HasMaxLength(500) 
                   .IsRequired(false); 
        }
    }
}
