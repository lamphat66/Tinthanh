using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
 
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class ThanhphamTailieuConfig : IEntityTypeConfiguration<Thanhpham_Tailieu>
    {
        public void Configure(EntityTypeBuilder<Thanhpham_Tailieu> builder)
        {
            builder.ToTable("Thanhpham_Tailieu");
            builder.Property(x => x.Tenfile).IsRequired().HasMaxLength(100);


            builder.HasOne(x => x.Thanhpham)
                .WithMany(x => x.Thanhpham_Tailieus)
                .HasForeignKey(x => x.ThanhphamId)

                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
           

        }
    }
}
