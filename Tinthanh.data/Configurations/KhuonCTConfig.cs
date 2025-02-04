using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class KhuonCTConfig : IEntityTypeConfiguration<KhuonCT>
    {
        public void Configure(EntityTypeBuilder<KhuonCT> builder)
        {
            builder.ToTable("Khuon_CT");
            builder.Property(x => x.Masp).HasMaxLength(20).IsRequired();
            builder.Property(x => x.TenSP).IsRequired().HasMaxLength(80);
            builder.Property(x => x.Donvi).HasMaxLength(20);

            builder.HasOne(x => x.Khuon)
                .WithMany(x => x.KhuonCTs)
                .HasForeignKey(x => x.KhuonId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
