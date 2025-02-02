using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class LoaidanhdiemConfig : IEntityTypeConfiguration<Loaidanhdiem>
    {
        public void Configure(EntityTypeBuilder<Loaidanhdiem> builder)
        {
            builder.ToTable("Loaidanhdiem");

            builder.HasKey(x => x.Ma);

            builder.Property(x => x.Ma).HasMaxLength(20);

            builder.Property(x => x.Ten).IsRequired().HasMaxLength(80);
          

        }
    }
}
