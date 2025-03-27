using HMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure._Data.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(r => r.Number).IsRequired();

            builder.Property(p => p.Type)
                       .HasConversion(
                       (type) => type.ToString(),
                       (gen) => Enum.Parse<RoomType>(gen, true)).HasMaxLength(55);

            builder.Property(p => p.Status)
                    .HasConversion(
                    (type) => type.ToString(),
                    (gen) => Enum.Parse<RoomStatus>(gen, true)).HasMaxLength(55);
        }
    }
}
