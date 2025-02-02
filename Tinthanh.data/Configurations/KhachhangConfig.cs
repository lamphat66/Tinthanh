using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class KhachhangConfig : IEntityTypeConfiguration<Khachhang>
    {
        public void Configure(EntityTypeBuilder<Khachhang> builder)
        {

            builder.ToTable("Khachhang");
            builder.HasIndex(x => x.Ma).IsUnique();
            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.Property(x => x.Manhom).HasMaxLength(20);
            builder.HasIndex(b => b.Manhom, "IX_Khachhang");
            builder.Property(x => x.Makv).HasMaxLength(20);
            builder.Property(x => x.Ten).HasMaxLength(100).IsRequired();
            builder.Property(x => x.LinkNhaCC).HasMaxLength(20);
            
            builder.Property(x => x.Taikhoan).HasMaxLength(20);
            builder.Property(x => x.Ghichu).HasMaxLength(200);
            builder.Property(x => x.Lienhe).HasMaxLength(100);
            builder.Property(x => x.Diachi).HasMaxLength(200);
            builder.Property(x => x.Tentat).HasMaxLength(100);


        }
    }
}
