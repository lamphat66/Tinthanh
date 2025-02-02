using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class KhuonConfig : IEntityTypeConfiguration<Khuon>
    {
        public void Configure(EntityTypeBuilder<Khuon> builder)
        {
            builder.ToTable("Khuon");
            builder.HasIndex(b => b.Ma).IsUnique();
            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.Property(x => x.Ten).HasMaxLength(100);
            builder.Property(x => x.Mats).HasMaxLength(20);
            builder.Property(x => x.Make).HasMaxLength(20);
            builder.Property(x => x.Makh).HasMaxLength(20);
            builder.Property(x => x.TenKH).HasMaxLength(100);
            builder.Property(x => x.Mats).HasMaxLength(20);
            builder.Property(x => x.CreateDate).HasDefaultValueSql("getdate()");
          
            builder.HasIndex(b => b.Manhom, "IX_Nhomkhuon");
            builder.Property(b => b.Manhom).HasMaxLength(20);
            builder.Property(b => b.Ghichu).HasMaxLength(200);
        }
    }
}
