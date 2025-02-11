using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class PhieudinhgiaCTcf : IEntityTypeConfiguration<PhieudinhgiaCT>
    {
        public void Configure(EntityTypeBuilder<PhieudinhgiaCT> builder)
        {

            builder.ToTable("Phieudinhgia_CT");

            builder.HasOne(x => x.Phieudinhgia)
                .WithMany(x => x.PhieudinhgiaCTs)
                .HasForeignKey(x => x.PhieudinhgiaId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
