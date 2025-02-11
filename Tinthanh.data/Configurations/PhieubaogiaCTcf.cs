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

            builder.HasOne(x => x.Phieubaogia)
                .WithMany(x => x.PhieubaogiaCTs)
                .HasForeignKey(x => x.PhieubaogiaId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
