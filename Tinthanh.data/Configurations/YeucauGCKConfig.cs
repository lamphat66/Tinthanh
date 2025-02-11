using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class YeucauGCKConfig : IEntityTypeConfiguration<YeucauGCK>
    {
        public void Configure(EntityTypeBuilder<YeucauGCK> builder)
        {

            builder.ToTable("YeucauGCK");
            builder.HasIndex(x=>x.Maphieu).IsUnique();
    
        }
    }
}
