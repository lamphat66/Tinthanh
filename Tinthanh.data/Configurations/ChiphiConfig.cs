using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class ChiphiConfig : IEntityTypeConfiguration<Chiphi>
    {
        public void Configure(EntityTypeBuilder<Chiphi> builder)
        {
            builder.ToTable("Chiphi");
            builder.HasIndex(x => x.Ma).IsUnique();
            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.Property(x => x.Loai).HasMaxLength(20);
            builder.Property(x => x.Ten).IsRequired();
           


        }
    }
}
