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
    public class LienlacNhaCCConfig : IEntityTypeConfiguration<LienlacNCC>
    {
        public void Configure(EntityTypeBuilder<LienlacNCC> builder)
        {

            builder.ToTable("LienlacNCC");
            
            builder.Property(x => x.Diachi).HasMaxLength(100);
            builder.Property(x => x.Hoten).IsRequired();
            builder.HasOne(x => x.Nhacungcap)
                .WithMany(x => x.LienlacNCCs)
                .HasForeignKey(x => x.NhacungcapId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
 
        }
    }
};
