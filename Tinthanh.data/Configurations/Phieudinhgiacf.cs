using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class Phieudinhgiacf : IEntityTypeConfiguration<Phieudinhgia>
    {
        public void Configure(EntityTypeBuilder<Phieudinhgia> builder)
        {


            builder.ToTable("Phieudinhgia");
            builder.HasIndex(x => x.Maphieu).IsUnique();
            builder.Property(x => x.Maphieu).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Makh).HasMaxLength(20);
            builder.Property(x => x.Tenkh).HasMaxLength(100);
            builder.Property(x => x.CreateBy).HasMaxLength(20);
            builder.Property(x => x.EditBy).HasMaxLength(20);
            builder.Property(x => x.Ghichu).HasMaxLength(200);
            builder.Property(x => x.Masp).HasMaxLength(20);
            builder.Property(x => x.Tensp).HasMaxLength(100);
            builder.Property(x => x.Khomay).HasMaxLength(20);
            builder.Property(x => x.SLTheo).HasMaxLength(20);
            builder.Property(x => x.MaTC).HasMaxLength(20);
            builder.Property(x => x.TenTC).HasMaxLength(100);
            builder.Property(x => x.Makhuon).HasMaxLength(20);
            builder.Property(x => x.Tenkhuon).HasMaxLength(100);

        }
    }
}
