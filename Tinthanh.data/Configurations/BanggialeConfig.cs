using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class BanggialeConfig : IEntityTypeConfiguration<Banggiale>
    {
        public void Configure(EntityTypeBuilder<Banggiale> builder)
        {
            builder.ToTable("Banggiale");
            builder.HasIndex(p =>p.Masp).IsUnique();
            builder.Property(x => x.TenSP).HasMaxLength(100);
            builder.Property(x => x.Donvi).HasMaxLength(20);
            builder.Property(x => x.Khomay).HasMaxLength(20);
            builder.Property(x => x.Users).HasMaxLength(20);

        }
    }
}
