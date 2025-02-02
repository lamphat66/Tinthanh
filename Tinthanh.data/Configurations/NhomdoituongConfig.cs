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
    public class NhomdoituongConfig : IEntityTypeConfiguration<Nhomdoituong>
    {
        public void Configure(EntityTypeBuilder<Nhomdoituong> builder)
        {
            builder.ToTable("Nhomdoituong");
            builder.HasKey(x => x.Ma);
            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.Property(x => x.Madt).HasMaxLength(20);

            builder.Property(x => x.Ten).IsRequired().HasMaxLength(80);

            builder.HasOne(x => x.Loaidoituong)
                .WithMany(x => x.Nhomdoituongs)
                .HasForeignKey(x => x.Madt)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
