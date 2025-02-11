using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class PhieuthukhuonConfig : IEntityTypeConfiguration<Phieuthukhuon>
    {
        public void Configure(EntityTypeBuilder<Phieuthukhuon> builder)
        {

            builder.ToTable("Phieuthukhuon");
            builder.HasIndex(x=>x.Maphieu).IsUnique();
    
        }
    }
}
