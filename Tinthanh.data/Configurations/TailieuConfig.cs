using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class TailieuConfig : IEntityTypeConfiguration<Tailieu>
    {
        public void Configure(EntityTypeBuilder<Tailieu> builder)
        {
            builder.ToTable("Tailieu");
            builder.Property(x => x.Madt).HasMaxLength(20);
            builder.HasIndex(b => b.Madt, "IX_Tailieu");
            builder.Property(x => x.Phanloai).HasMaxLength(20);
            builder.Property(x => x.Nhomtaileu).HasMaxLength(20);
            builder.HasIndex(b => b.Nhomtaileu, "IX_Nhomtailieu");
            builder.Property(x => x.Tenfile).IsRequired().HasMaxLength(100);   
            builder.Property(x => x.Mota).HasMaxLength(200);
            builder.Property(x => x.Ngungsd).HasDefaultValue(false);
            builder.Property(x=>x.CreateDate).HasDefaultValueSql("getdate()");


        }
    }
}
