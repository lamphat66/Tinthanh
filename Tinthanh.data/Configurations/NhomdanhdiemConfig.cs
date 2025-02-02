using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class NhomdanhdiemConfig: IEntityTypeConfiguration<Nhomdanhdiem>
    {
        public void Configure(EntityTypeBuilder<Nhomdanhdiem> builder)
        {
            builder.ToTable("Nhomdanhdiem");

            builder.HasKey(x => x.Ma);

            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.Property(x => x.Madd).HasMaxLength(20);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(80);
            builder.HasOne(x => x.Loaidanhdiem).WithMany(x => x.Nhomdanhdiems).HasForeignKey(x => x.Madd);
        }
    }
}
