using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class XebaotriConfig : IEntityTypeConfiguration<XeBaoTri>
    {
        public void Configure(EntityTypeBuilder<XeBaoTri> builder)
        {
            builder.ToTable("Xe_Baotri");
           
            builder.Property(x => x.Soxe).HasMaxLength(20);
            builder.Property(x => x.Hinhthuc).HasMaxLength(20);
            builder.Property(x => x.Ghichu).HasMaxLength(200);

            builder.HasOne(x => x.Xemay)
                .WithMany(x => x.XeBaoTris)
                .HasForeignKey(x => x.XemayId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            

        }
    }
}
