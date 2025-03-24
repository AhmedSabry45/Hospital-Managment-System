﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure._Data.Configurations
{
    public class WardConfiguration : IEntityTypeConfiguration<Ward>
    {
        public void Configure(EntityTypeBuilder<Ward> builder)
        {
            builder.Property(w => w.Name)
               .IsRequired()
               .HasMaxLength(100);

            builder.Property(w => w.Type)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(w => w.Capacity)
                   .IsRequired();
        }
    }
}
