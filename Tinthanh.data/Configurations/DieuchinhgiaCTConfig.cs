using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class DieuchinhgiaCTConfig : IEntityTypeConfiguration<DieuchinhgiaCT>
    {
        public void Configure(EntityTypeBuilder<DieuchinhgiaCT> builder)
        {

            builder.ToTable("Dieuchinhgia_CT");

            builder.HasOne(x => x.Dieuchinhgia)
                .WithMany(x => x.DieuchinhgiaCTs)
                .HasForeignKey(x => x.DieuchinhgiaId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
