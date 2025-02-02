using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class KhoConfig : IEntityTypeConfiguration<Kho>
    {
        public void Configure(EntityTypeBuilder<Kho> builder)
        {
            builder.ToTable("Kho");
            builder.HasIndex(x => x.Ma).IsUnique();
            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.Property(x => x.Ten).HasMaxLength(100);
            builder.Property(x => x.Ten).IsRequired();
            builder.Property(x => x.Diachi).HasMaxLength(100);
            builder.Property(x => x.Manhom).HasMaxLength(20);
            builder.Property(x => x.Dienthoai).HasMaxLength(30);


        }
    }
}
