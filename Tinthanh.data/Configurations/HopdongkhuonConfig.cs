using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class HopdongkhuonConfig : IEntityTypeConfiguration<Hopdongkhuon>
    {
        public void Configure(EntityTypeBuilder<Hopdongkhuon> builder)
        {

            builder.ToTable("YeucauGCK");
            builder.HasIndex(x=>x.Maphieu).IsUnique();
    
        }
    }
}
