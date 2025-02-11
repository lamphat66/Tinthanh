using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class ThongtinSPConfig : IEntityTypeConfiguration<ThongtinSP>
    {
        public void Configure(EntityTypeBuilder<ThongtinSP> builder)
        {

            builder.ToTable("ThongtinSP");
            builder.HasIndex(x=>x.Maphieu).IsUnique();
    
        }
    }
}
