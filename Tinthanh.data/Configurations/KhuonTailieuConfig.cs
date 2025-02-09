using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
 
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class KhuonTailieuConfig : IEntityTypeConfiguration<Khuon_Tailieu>
    {
        public void Configure(EntityTypeBuilder<Khuon_Tailieu> builder)
        {
            builder.ToTable("Khuon_Tailieu");
            builder.Property(x => x.Tenfile).IsRequired().HasMaxLength(100);


            builder.HasOne(x => x.Khuon)
                .WithMany(x => x.Khuon_Tailieus)
                .HasForeignKey(x => x.KhuonId)

                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
           

        }
    }
}
