using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class KhomayConfig : IEntityTypeConfiguration<Khomay>
    {
        public void Configure(EntityTypeBuilder<Khomay> builder)
        {
            builder.ToTable("Khomay");
            builder.HasKey(x => x.Ma);
            builder.Property(x => x.Ma).ValueGeneratedNever();
            builder.Property(x => x.Ten).HasMaxLength(80);
           


        }
    }
}
