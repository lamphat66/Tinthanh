using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class HinhvattuConfig : IEntityTypeConfiguration<Hinhvattu>
    {
        public void Configure(EntityTypeBuilder<Hinhvattu> builder)
        {
            builder.ToTable("Hinhvattu");

            builder.HasKey(x => x.Mavt);

            builder.Property(x => x.Mavt).HasMaxLength(20);
        }
    }
}
