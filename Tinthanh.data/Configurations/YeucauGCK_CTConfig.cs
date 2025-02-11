using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class YeucauGCK_CTConfig: IEntityTypeConfiguration<YeucauGCK_CT>
    {
        public void Configure(EntityTypeBuilder<YeucauGCK_CT> builder)
        {

            builder.ToTable("YeucauGCK_CT");

            builder.HasOne(x => x.YeucauGCK)
                .WithMany(x => x.YeucauGCK_CTs)
                .HasForeignKey(x => x.YeucauGCKId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
