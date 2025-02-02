using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class KhuvucConfig : IEntityTypeConfiguration<Khuvuc>
    {
        public void Configure(EntityTypeBuilder<Khuvuc> builder)
        {
            builder.ToTable("Khuvuc");

            builder.HasIndex(x => x.Ma).IsUnique();

            builder.Property(x => x.Ma).HasMaxLength(20);

            builder.Property(x => x.Ten).IsRequired().HasMaxLength(80);
           


        }
    }
}
