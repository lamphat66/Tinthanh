using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class NhacungcapConfig : IEntityTypeConfiguration<Nhacungcap>
    {
        public void Configure(EntityTypeBuilder<Nhacungcap> builder)
        {
            builder.ToTable("Nhacungcap");
            builder.HasIndex(x => x.Ma).IsUnique();
            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.Property(x => x.Manhom).HasMaxLength(20);
            builder.HasIndex(b => b.Manhom, "IX_NhomNhacungcap");
            builder.Property(x => x.Ten).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Linkkh).HasMaxLength(20);
            builder.Property(x => x.Diachi).HasMaxLength(100);
            builder.Property(x => x.Taikhoan).HasMaxLength(20);
            builder.Property(x => x.Ghichu).HasMaxLength(200);

        }
    }
}
