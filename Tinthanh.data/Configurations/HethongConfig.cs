using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class HethongConfig : IEntityTypeConfiguration<Hethong>
    {
        public void Configure(EntityTypeBuilder<Hethong> builder)
        {
            builder.ToTable("Hethong");
            builder.HasKey(x => x.Macty);
            builder.Property(x => x.Macty).HasMaxLength(20);

            builder.Property(x => x.Tencty).IsRequired(); 
           


        }
    }
}
