using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class HopdongkhuonConfig : IEntityTypeConfiguration<Hopdongkhuon>
    {
        public void Configure(EntityTypeBuilder<Hopdongkhuon> builder)
        {

            builder.ToTable("Hopdongkhuon");
            builder.HasIndex(x=>x.Maphieu).IsUnique();
            builder.Property(x => x.Maphieu).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Makh).HasMaxLength(20);
            builder.Property(x => x.Tenkh).HasMaxLength(100);
            builder.Property(x => x.CreateBy).HasMaxLength(20);
            builder.Property(x => x.EditBy).HasMaxLength(20);
            builder.Property(x => x.Ghichu).HasMaxLength(200);
            builder.Property(x => x.Sohopdong).HasMaxLength(20);
            builder.Property(x => x.PathFile).HasMaxLength(100);
            builder.Property(x => x.Bienban).HasMaxLength(30);
            

        }
    }
}
