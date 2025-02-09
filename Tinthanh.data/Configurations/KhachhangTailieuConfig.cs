using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
 
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class KhachhangTailieuConfig : IEntityTypeConfiguration<Khachhang_Tailieu>
    {
        public void Configure(EntityTypeBuilder<Khachhang_Tailieu> builder)
        {
            builder.ToTable("Khachhang_Tailieu");

            builder.Property(x => x.Tenfile).IsRequired().HasMaxLength(100);

            builder.HasOne(x => x.Khachhang)
                .WithMany(x => x.Khachhang_Tailieus)
                .HasForeignKey(x => x.KhachhangId)

                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
           

        }
    }
}
