using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class PhieuyeucauCTcf : IEntityTypeConfiguration<PhieuyeucauCT>
    {
        public void Configure(EntityTypeBuilder<PhieuyeucauCT> builder)
        {
            builder.ToTable("Phieuyeucau_CT");
            
            builder.HasOne(x => x.Phieuyeucau)
                .WithMany(x => x.PhieuyeucauCTs)
                .HasForeignKey(x => x.PhieuyeucauId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
