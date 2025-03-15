using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class ChungtuConfig : IEntityTypeConfiguration<Chungtu>
    {
        public void Configure(EntityTypeBuilder<Chungtu> builder)
        {
            builder.ToTable("Chungtu");
            builder.HasKey(x => x.Maphieu);
            builder.Property(x => x.Maphieu).HasMaxLength(20);
            
           
        }
    }
}
