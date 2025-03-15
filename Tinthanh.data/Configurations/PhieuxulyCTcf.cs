using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class PhieuxulyCTcf : IEntityTypeConfiguration<PhieuxulyCT>
    {
        public void Configure(EntityTypeBuilder<PhieuxulyCT> builder)
        {

            builder.ToTable("Phieuxuly_CT");
            builder.Property(x => x.Masp).HasMaxLength(20);
            builder.Property(x => x.Tensp).HasMaxLength(100);
            builder.Property(x => x.Donvi).HasMaxLength(20);
            builder.HasOne(x => x.Phieuxuly)
                .WithMany(x => x.PhieuxulyCTs)
                .HasForeignKey(x => x.PhieuxulyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
