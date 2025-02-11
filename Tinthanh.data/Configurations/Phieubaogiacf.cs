using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class Phieubaogiacf : IEntityTypeConfiguration<Phieubaogia>
    {
        public void Configure(EntityTypeBuilder<Phieubaogia> builder)
        {

            builder.ToTable("Phieubaogia");
            builder.HasIndex(x=>x.Maphieu).IsUnique();
    
        }
    }
}
