using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure._Data.Configurations
{
    public class AdmissionConfiguration : IEntityTypeConfiguration<Admission>
    {
        public void Configure(EntityTypeBuilder<Admission> builder)
        {
            builder.Property(a => a.DiagnosisOnAdmission)
                .HasMaxLength(255);


            builder.Property(a => a.Notes)
                .HasMaxLength(750);


        }
    }
}
