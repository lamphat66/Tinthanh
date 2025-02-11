using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class PhieuxulyCTcf : IEntityTypeConfiguration<PhieuxulyCT>
    {
        public void Configure(EntityTypeBuilder<PhieuxulyCT> builder)
        {

            builder.ToTable("Phieuxuly_CT");

            builder.HasOne(x => x.Phieuxuly)
                .WithMany(x => x.PhieuxulyCTs)
                .HasForeignKey(x => x.PhieuxulyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
