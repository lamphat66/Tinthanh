using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class LoaiddoituongConfig : IEntityTypeConfiguration<Loaidoituong>
    {
        public void Configure(EntityTypeBuilder<Loaidoituong> builder)
        {
            builder.ToTable("Loaidoituong");

            builder.HasKey(x => x.Ma);

            builder.Property(x => x.Ma).HasMaxLength(20);

            builder.Property(x => x.Ten).IsRequired().HasMaxLength(80);
           


        }
    }
}
