using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class PhieuyeucauCTcf : IEntityTypeConfiguration<PhieuyeucauCT>
    {
        public void Configure(EntityTypeBuilder<PhieuyeucauCT> builder)
        {
            builder.ToTable("Phieuyeucau_CT");
            builder.Property(x => x.Masp).HasMaxLength(20);
            builder.Property(x => x.Tensp).HasMaxLength(100);
            builder.Property(x => x.Ghichu).HasMaxLength(100);
          
            builder.HasOne(x => x.Phieuyeucau)
                .WithMany(x => x.PhieuyeucauCTs)
                .HasForeignKey(x => x.PhieuyeucauId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
