using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class DonvisanphamConfig : IEntityTypeConfiguration<Donvisanpham>
    {
        public void Configure(EntityTypeBuilder<Donvisanpham> builder)
        {
            builder.ToTable("Donvisanpham");
            builder.Property(x => x.Donvi).HasMaxLength(20).IsRequired();

          
            builder.HasOne(x => x.Thanhpham)
                .WithMany(x => x.Donvisanphams)
                .HasForeignKey(x => x.ThanhphamId)

                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            builder.Property(x => x.Ngungsd).HasDefaultValue(false);

        }
    }
}
