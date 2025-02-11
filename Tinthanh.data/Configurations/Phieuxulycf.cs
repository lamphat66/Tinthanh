using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class Phieuxulycf : IEntityTypeConfiguration<Phieuxuly>
    {
        public void Configure(EntityTypeBuilder<Phieuxuly> builder)
        {

            builder.ToTable("Phieuxuly");
            builder.HasIndex(x=>x.Maphieu).IsUnique();
    
        }
    }
}
