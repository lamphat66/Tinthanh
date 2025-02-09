using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
 
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class VattuTailieuConfig : IEntityTypeConfiguration<Vattu_Tailieu>
    {
        public void Configure(EntityTypeBuilder<Vattu_Tailieu> builder)
        {
            builder.ToTable("Vattu_Tailieu");

            builder.Property(x=>x.Tenfile).IsRequired().HasMaxLength(100);


            builder.HasOne(x => x.Vattu)
                .WithMany(x => x.VattuTailieus)
                .HasForeignKey(x => x.VattuId)

                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
           

        }
    }
}
