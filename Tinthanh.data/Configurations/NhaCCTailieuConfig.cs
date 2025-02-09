using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
 
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class NhaCCTailieuConfig : IEntityTypeConfiguration<NhaCC_Tailieu>
    {
        public void Configure(EntityTypeBuilder<NhaCC_Tailieu> builder)
        {
            builder.ToTable("NhaCC_Tailieu");
            builder.Property(x => x.Tenfile).IsRequired().HasMaxLength(100);


            builder.HasOne(x => x.Nhacungcap)
                .WithMany(x => x.NhaCC_Tailieus)
                .HasForeignKey(x => x.NhacungcapId)

                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
           

        }
    }
}
