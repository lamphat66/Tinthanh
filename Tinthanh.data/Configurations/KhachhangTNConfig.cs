using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class KhachhangTNConfig : IEntityTypeConfiguration<KhachhangTN>
    {
        public void Configure(EntityTypeBuilder<KhachhangTN> builder)
        {
            builder.ToTable("KhachhangTN");
            builder.HasIndex(x => x.Ma).IsUnique();
            builder.Property(x => x.Ma).HasMaxLength(20);
            
            builder.Property(x => x.Ten).HasMaxLength(80).IsRequired();
        
            builder.Property(x => x.Diachi).HasMaxLength(100).IsRequired();
             

        }
    }
}
