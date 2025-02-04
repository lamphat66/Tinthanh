using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

public class VattuConfig : IEntityTypeConfiguration<Vattu>
{
    public void Configure(EntityTypeBuilder<Vattu> builder)
    {

        builder.ToTable("Vattu");
        builder.HasIndex(x => x.Ma).IsUnique();
        builder.Property(x => x.Ma).HasMaxLength(20);
        builder.Property(x => x.Kho).HasMaxLength(20);
        builder.Property(x => x.Ten).IsRequired().HasMaxLength(100);
        builder.HasIndex(b => b.Manhom, "IX_NhomVattu");

        builder.Property(x => x.Ghichu).HasMaxLength(200);




    }
}