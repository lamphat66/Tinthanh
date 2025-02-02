using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class DateDimConfig : IEntityTypeConfiguration<DateDim>
    {
        public void Configure(EntityTypeBuilder<DateDim> builder)
        {
            builder.ToTable("DateDim");

            builder.HasKey(x => x.TheDate);

        }
    }
}
