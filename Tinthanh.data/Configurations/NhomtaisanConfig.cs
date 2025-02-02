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
    public class NhomtaisanConfig: IEntityTypeConfiguration<Nhomtaisan>
    {
        public void Configure(EntityTypeBuilder<Nhomtaisan> builder)
        {
            builder.ToTable("Nhomtaisan");

            builder.HasKey(x => x.Ma);
            builder.Property(x=>x.Ngungsd).HasDefaultValue(false);
            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.Property(x => x.Mats).HasMaxLength(20);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(80);
            builder.HasOne(x => x.Loaitaisan).WithMany(x => x.Nhomtaisans).HasForeignKey(x => x.Mats);
        }
    }
}
