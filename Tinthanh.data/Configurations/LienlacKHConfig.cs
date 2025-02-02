using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class LienlacKHConfig : IEntityTypeConfiguration<LienlacKH>
    {
        public void Configure(EntityTypeBuilder<LienlacKH> builder)
        {
            builder.ToTable("LienlacKH");
            
            builder.Property(x => x.Diachi).HasMaxLength(100);

            builder.Property(x => x.Hoten).IsRequired();

            builder.HasOne(x => x.Khachhang)
                .WithMany(x => x.LienlacKHs)  
                .HasForeignKey(x => x.KhachhangId)
                .IsRequired()
               
                .OnDelete(DeleteBehavior.Cascade);
             
        }
    }
}
