using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(x => x.Ma).HasMaxLength(20);
            builder.HasKey(x => x.Ma);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(80);
            builder.Property(b => b.Ngaytao).HasDefaultValueSql("getdate()");

        }
    }
}
