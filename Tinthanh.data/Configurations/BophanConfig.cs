using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class BophanConfig : IEntityTypeConfiguration<Bophan>
    {
        public void Configure(EntityTypeBuilder<Bophan> builder)
        {
            builder.ToTable("Bophan");
            builder.HasIndex(x=>x.Ma).IsUnique();
            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.Property(x => x.Ten).IsRequired();
           
        }
    }
}
