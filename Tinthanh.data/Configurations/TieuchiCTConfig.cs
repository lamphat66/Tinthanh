using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
 
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class TieuchiCTConfig : IEntityTypeConfiguration<TieuchiCT>
    {
        public void Configure(EntityTypeBuilder<TieuchiCT> builder)
        {
            builder.ToTable("TieuchiCT");
            builder.Property(x => x.Ten).IsRequired();
            
            builder.HasOne(x => x.TieuchiKT)
                .WithMany(x => x.TieuchiCTs)
                .HasForeignKey(x => x.TieuchiKTMa)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
