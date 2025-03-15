using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class HopdongkhuonCTConfig : IEntityTypeConfiguration<HopdongkhuonCT>
    {
        public void Configure(EntityTypeBuilder<HopdongkhuonCT> builder)
        {

            builder.ToTable("Hopdongkhuon_CT");
            builder.Property(x => x.Makhuon).HasMaxLength(20);
            builder.Property(x => x.Tenkhuon).HasMaxLength(100);
            builder.Property(x => x.Donvi).HasMaxLength(20);
            builder.Property(x => x.Khomay).HasMaxLength(20);
            builder.HasOne(x => x.Hopdongkhuon)
                .WithMany(x => x.HopdongkhuonCTs)
                .HasForeignKey(x => x.HopdongkhuonId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
