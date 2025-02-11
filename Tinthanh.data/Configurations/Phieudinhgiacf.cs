using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class Phieudinhgiacf : IEntityTypeConfiguration<Phieudinhgia>
    {
        public void Configure(EntityTypeBuilder<Phieudinhgia> builder)
        {

            builder.ToTable("Phieudinhgia");
            builder.HasIndex(x=>x.Maphieu).IsUnique();
    
        }
    }
}
