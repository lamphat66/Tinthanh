using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class PhieuthukhuonConfig : IEntityTypeConfiguration<Phieuthukhuon>
    {
        public void Configure(EntityTypeBuilder<Phieuthukhuon> builder)
        {

            builder.ToTable("Phieuthukhuon");
            builder.HasIndex(x=>x.Maphieu).IsUnique();
            builder.Property(x => x.NVkichhat).HasMaxLength(20);
            builder.Property(x => x.NVvanhanh).HasMaxLength(100);
            builder.Property(x => x.GhichuKM).HasMaxLength(200);
            builder.Property(x => x.GhichuCM).HasMaxLength(200);
            builder.Property(x => x.GhichuDG).HasMaxLength(200);
            builder.Property(x => x.Loaibao).HasMaxLength(20);
            builder.Property(x => x.Tenbao).HasMaxLength(100);
            builder.Property(x => x.TenNhua).HasMaxLength(100);
            builder.Property(x => x.Tenkichhat).HasMaxLength(100);
            builder.Property(x => x.TenDinhhinh).HasMaxLength(100);
            builder.Property(x => x.Makhuon).HasMaxLength(20);
            builder.Property(x => x.Tenkhuon).HasMaxLength(100);



        }
    }
}
