using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Tinthanh.Data.Configurations
{
    public class TaisanConfig : IEntityTypeConfiguration<Taisan>
    {
        public void Configure(EntityTypeBuilder<Taisan> builder)
        {
            builder.ToTable("Taisan");
            builder.HasIndex(b => b.Ma, "IX_Taisan").IsUnique();
            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(80);
            builder.Property(x => x.Loaits).HasMaxLength(20);
            builder.Property(b => b.CreateDate).HasDefaultValueSql("getdate()");
            builder.Property(x => x.Ngungsd).HasDefaultValue(false);
            builder.Property(x => x.Ghichu).HasMaxLength(200);
            builder.Property(x => x.Manhom).HasMaxLength(20);
            builder.HasIndex(b => b.Manhom, "IX_TaisanNhom");
        }
    }
}
