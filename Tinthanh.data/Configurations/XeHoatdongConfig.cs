using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class XeHoatdongConfig : IEntityTypeConfiguration<XeHoatdong>
    {
        public void Configure(EntityTypeBuilder<XeHoatdong> builder)
        {
            builder.ToTable("Xe_Hoatdong");
           
            builder.Property(x => x.Soxe).HasMaxLength(20);
            builder.Property(x => x.Ghichu).HasMaxLength(200);
         

            builder.HasOne(x => x.Xemay)
                .WithMany(x => x.XeHoatdongs)
                .HasForeignKey(x => x.XemayId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            

        }
    }
}
