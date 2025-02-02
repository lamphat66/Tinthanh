using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class DonviConfig : IEntityTypeConfiguration<Donvi>
    {
        public void Configure(EntityTypeBuilder<Donvi> builder)
        {
            builder.ToTable("Donvi");

            builder.HasKey(x => x.Ma);

            builder.Property(x => x.Ma).HasMaxLength(20);

            builder.Property(x => x.Ten).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Ngungsd).HasDefaultValue(false);



        }
    }
}
