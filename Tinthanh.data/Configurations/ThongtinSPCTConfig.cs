using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class ThongtinSPCTConfig: IEntityTypeConfiguration<ThongtinSP_CT>
    {
        public void Configure(EntityTypeBuilder<ThongtinSP_CT> builder)
        {

            builder.ToTable("ThongtinSP_CT");

            builder.HasOne(x => x.ThongtinSP)
                .WithMany(x => x.ThongtinSP_CTs)
                .HasForeignKey(x => x.ThongtinSPId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
