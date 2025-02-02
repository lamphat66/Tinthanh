using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class ChucnangConfig : IEntityTypeConfiguration<Chucnang>
    {
        public void Configure(EntityTypeBuilder<Chucnang> builder)
        {
            builder.ToTable("Chucnang");
            builder.HasKey(t => t.Ma);
            builder.Property(x=>x.Ma).ValueGeneratedNever();
            builder.Property(x => x.Ten).IsRequired();

        }
    }
}
