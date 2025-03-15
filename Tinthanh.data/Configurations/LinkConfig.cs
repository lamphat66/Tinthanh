using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class LinkConfig : IEntityTypeConfiguration<Link>
    {
        public void Configure(EntityTypeBuilder<Link> builder)
        {
            builder.ToTable("Link");
            
            builder.Property(x => x.CopyFrom).HasMaxLength(20);
            builder.Property(x => x.CopyTo).HasMaxLength(20);
            builder.HasKey(x => new { x.CopyFrom, x.CopyTo });
            
             
        }
    }
}
