using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class DangkiemConfig : IEntityTypeConfiguration<Dangkiem>
    {
        public void Configure(EntityTypeBuilder<Dangkiem> builder)
        {
            builder.ToTable("Dangkiem");
            builder.HasIndex(x => x.Madt, "IX_Dangkiem");
            builder.Property(x => x.Madt).HasMaxLength(20);
            builder.Property(x => x.Nhacc).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Tennhacc).IsRequired().HasMaxLength(80);
            builder.Property(x => x.Soct).HasMaxLength(20);
            builder.Property(x => x.Loai).HasMaxLength(20);
            builder.Property(x => x.Tailieu).HasMaxLength(80);
            


        }
    }
}
