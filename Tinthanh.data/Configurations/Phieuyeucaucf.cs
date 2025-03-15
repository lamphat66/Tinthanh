using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class Phieuyeucaucf : IEntityTypeConfiguration<Phieuyeucau>
    {
        public void Configure(EntityTypeBuilder<Phieuyeucau> builder)
        {

            builder.ToTable("Phieuyeucau");
            builder.HasIndex(x => x.Maphieu).IsUnique();
            builder.Property(x => x.Maphieu).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Makh).HasMaxLength(20);
            builder.Property(x => x.Tenkh).HasMaxLength(100);
            builder.Property(x => x.CreateBy).HasMaxLength(20);
            builder.Property(x => x.EditBy).HasMaxLength(20);
            builder.Property(x => x.Ghichu).HasMaxLength(200);
            builder.Property(x => x.Diachi).HasMaxLength(100);
            builder.Property(x => x.Dienthoai).HasMaxLength(30);
            builder.Property(x => x.Nguoinhan1).HasMaxLength(20);
            builder.Property(x => x.NguoiVC1).HasMaxLength(20);
            builder.Property(x => x.NguoiXL1).HasMaxLength(20);
             

        }
    }
}
