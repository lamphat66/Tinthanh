using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class CongviecBTConfig : IEntityTypeConfiguration<CongviecBT>
    {
        public void Configure(EntityTypeBuilder<CongviecBT> builder)
        {
            builder.ToTable("Congviec_BT");
            builder.HasKey(x => x.Ma);
            builder.Property(x => x.Ma).ValueGeneratedNever();
            builder.Property(x => x.Dungcu).HasMaxLength(200);
        
        }
    }
}
