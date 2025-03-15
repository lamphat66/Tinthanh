using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class PhieubaogiaCTcf : IEntityTypeConfiguration<PhieubaogiaCT>
    {
        public void Configure(EntityTypeBuilder<PhieubaogiaCT> builder)
        {

            builder.ToTable("Phieubaogia_CT");
            builder.Property(x => x.Masp).HasMaxLength(20);
            builder.Property(x => x.Tensp).HasMaxLength(100);
            builder.Property(x => x.Donvi).HasMaxLength(20);
            builder.Property(x => x.Khomay).HasMaxLength(20);
          
            builder.HasOne(x => x.Phieubaogia)
                .WithMany(x => x.PhieubaogiaCTs)
                .HasForeignKey(x => x.PhieubaogiaId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
