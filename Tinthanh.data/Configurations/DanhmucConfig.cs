using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class DanhmucConfig : IEntityTypeConfiguration<Danhmuc>
    {
        public void Configure(EntityTypeBuilder<Danhmuc> builder)
        {
            builder.ToTable("Danhmuc");
            builder.HasKey(x => x.Ma);
            builder.Property(x => x.Ma).ValueGeneratedNever();
             
            builder.Property(x => x.Ten).IsRequired();
           
        }
    }
}
