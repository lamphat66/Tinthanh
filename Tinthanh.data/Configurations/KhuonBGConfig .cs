using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class KhuonBGConfig : IEntityTypeConfiguration<KhuonBG>
    {
       
        public void Configure(EntityTypeBuilder<KhuonBG> builder)
        {
            builder.ToTable("KhuonBG");
            builder.HasIndex(x => x.Ma).IsUnique();
            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(100);

        }
    }
}
