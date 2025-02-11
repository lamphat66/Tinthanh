using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class DieuchinhgiaConfig : IEntityTypeConfiguration<Dieuchinhgia>
    {
        public void Configure(EntityTypeBuilder<Dieuchinhgia> builder)
        {

            builder.ToTable("Dieuchinhgia");
            builder.HasIndex(x=>x.Maphieu).IsUnique();
    
        }
    }
}
