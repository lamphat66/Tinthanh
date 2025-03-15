using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class Phieuxulycf : IEntityTypeConfiguration<Phieuxuly>
    {
        public void Configure(EntityTypeBuilder<Phieuxuly> builder)
        {

            builder.ToTable("Phieuxuly");
            builder.HasIndex(x=>x.Maphieu).IsUnique();
            builder.Property(x => x.Maphieu).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Makh).HasMaxLength(20);
            builder.Property(x => x.Tenkh).HasMaxLength(100);
            builder.Property(x => x.CreateBy).HasMaxLength(20);
            builder.Property(x => x.EditBy).HasMaxLength(20);
            builder.Property(x => x.Ghichu).HasMaxLength(200);
            builder.Property(x => x.Kekhuon).HasMaxLength(20);
            builder.Property(x => x.Tenkhuon).HasMaxLength(80);
            builder.Property(x => x.Nguoinhan).HasMaxLength(20);
            builder.Property(x => x.Nguoivc).HasMaxLength(20);
            builder.Property(x => x.Nguoixl).HasMaxLength(20);


        }
    }
}
