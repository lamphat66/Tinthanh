using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class DieuchinhgiaConfig : IEntityTypeConfiguration<Dieuchinhgia>
    {
        public void Configure(EntityTypeBuilder<Dieuchinhgia> builder)
        {

            builder.ToTable("Dieuchinhgia");
            builder.HasIndex(x=>x.Maphieu).IsUnique();
            builder.HasIndex(x => x.Maphieu).IsUnique();
            builder.Property(x => x.Maphieu).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Makh).HasMaxLength(20);
            builder.Property(x => x.Tenkh).HasMaxLength(100);
            builder.Property(x => x.Makv).HasMaxLength(20);
            builder.Property(x => x.CreateBy).HasMaxLength(20);
            builder.Property(x => x.EditBy).HasMaxLength(20);
            builder.Property(x => x.Nhomsp).HasMaxLength(20);


        }
    }
}
