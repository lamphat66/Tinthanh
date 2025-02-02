using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class MaymocTBConfig : IEntityTypeConfiguration<MaymocTB>
    {
        public void Configure(EntityTypeBuilder<MaymocTB> builder)
        {
            builder.ToTable("MaymocTB");
            builder.HasIndex(x => x.Ma).IsUnique();
            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.Property(x => x.Ten).HasMaxLength(100);
            builder.Property(x => x.Mats).HasMaxLength(20);
            builder.Property(x => x.NuocSX).HasMaxLength(20);
            builder.Property(x => x.NhaSX).HasMaxLength(20);
            builder.Property(x => x.sochetao).HasMaxLength(30);
            builder.Property(x => x.Model).HasMaxLength(20);
            builder.Property(x => x.Soxacnhan).HasMaxLength(30);
            builder.Property(x => x.Ghichu).HasMaxLength(300);

            builder.Property(x => x.Mats).HasMaxLength(20);
            builder.Property(x => x.CreateDate).HasDefaultValueSql("getdate()");
          
            builder.HasIndex(b => b.Manhom, "IX_NhomMaymoc");
            builder.Property(b => b.Manhom).HasMaxLength(20);



        }
    }
}
