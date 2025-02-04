using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class DanhmucCTConfig : IEntityTypeConfiguration<DanhmucCT>
    {
        public void Configure(EntityTypeBuilder<DanhmucCT> builder)
        {
            builder.ToTable("Danhmuc_CT");
            builder.Property(x => x.Ten).IsRequired();
            
            builder.HasOne(x => x.Danhmuc)
                .WithMany(x => x.DanhmucCTs)
                .HasForeignKey(x => x.DanhmucId)

                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
           

        }
    }
}
