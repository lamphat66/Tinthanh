using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class BanggiaKHConfig : IEntityTypeConfiguration<BanggiaKH>
    {
        public void Configure(EntityTypeBuilder<BanggiaKH> builder)
        {
            builder.ToTable("BanggiaKH");
          //  builder.HasIndex(p => new { p.Masp, p.Makh }).IsUnique();
            builder.HasIndex(p => new { p.KhachhangId, p.SanphamId }).IsUnique();
            builder.Property(x => x.Masp).HasMaxLength(20);
            builder.Property(x => x.TenSPKH).HasMaxLength(100);
            builder.Property(x => x.TenSPTT).HasMaxLength(100);
            builder.Property(x => x.Donvi).HasMaxLength(20);
            builder.Property(x => x.Khomay).HasMaxLength(20);
            builder.Property(x => x.Marieng).HasMaxLength(20);
            builder.Property(x => x.Users).HasMaxLength(20);

        }
    }
}
