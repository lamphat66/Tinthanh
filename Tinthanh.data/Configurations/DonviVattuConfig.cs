using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class DonviVattuConfig : IEntityTypeConfiguration<DonviVattu>
    {
        public void Configure(EntityTypeBuilder<DonviVattu> builder)
        {
            builder.ToTable("DonviVattu");
            builder.Property(x => x.Donvi).HasMaxLength(20).IsRequired();
            
            builder.HasOne(x => x.Vattu)
                .WithMany(x => x.DonviVattus)
                .HasForeignKey(x => x.VattuId)
               
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            

        }
    }
}
