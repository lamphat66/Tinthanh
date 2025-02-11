using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class Phieuyeucaucf : IEntityTypeConfiguration<Phieuyeucau>
    {
        public void Configure(EntityTypeBuilder<Phieuyeucau> builder)
        {

            builder.ToTable("Phieuyeucau");
            builder.HasIndex(x=>x.Maphieu).IsUnique();
    
        }
    }
}
