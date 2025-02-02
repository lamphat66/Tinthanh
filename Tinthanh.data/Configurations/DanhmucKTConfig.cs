using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class DanhmucKTConfig : IEntityTypeConfiguration<DanhmucKT>
    {
        public void Configure(EntityTypeBuilder<DanhmucKT> builder)
        {
            builder.ToTable("Danhmuc_KT");
            builder.HasKey(x => x.Ma);
            builder.Property(x => x.Ma).ValueGeneratedNever();
            builder.Property(x => x.Ten).IsRequired();

        }
    }
}
