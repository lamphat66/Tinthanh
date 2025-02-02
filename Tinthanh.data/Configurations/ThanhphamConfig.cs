using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class ThanhphamConfig : IEntityTypeConfiguration<Thanhpham>
    {
        public void Configure(EntityTypeBuilder<Thanhpham> builder)
        {
            builder.ToTable("Thanhpham");
            builder.HasIndex(x => x.Ma).IsUnique();
            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(100);
            builder.HasIndex(b => b.Manhom, "IX_Nhomthanhpham");

            builder.Property(x => x.Ghichu).HasMaxLength(200);



        }
    }
}
