using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class BanggiaNCCConfig : IEntityTypeConfiguration<BanggiaNCC>
    {
        public void Configure(EntityTypeBuilder<BanggiaNCC> builder)
        {
            builder.ToTable("BanggiaNCC");
          //  builder.HasIndex(p => new { p.MaVT, p.MaDT }).IsUnique();
            builder.HasIndex(p => new { p.NhaCCId, p.VattuId }).IsUnique();
          
            builder.Property(x => x.TenVT).HasMaxLength(100);
            builder.Property(x => x.TenNB).HasMaxLength(100);
            builder.Property(x => x.Donvi).HasMaxLength(20);
            builder.Property(x => x.Ghichu).HasMaxLength(200);
            builder.Property(x => x.Users).HasMaxLength(20);




        }
    }
}
