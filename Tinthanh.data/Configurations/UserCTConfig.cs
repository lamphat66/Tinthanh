using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tinthanh.Data.Entities;

namespace Tinthanh.Data.Configurations
{
    public class UserCTConfig : IEntityTypeConfiguration<User_CT>
    {
        public void Configure(EntityTypeBuilder<User_CT> builder)
        {
            builder.ToTable("User_CT");
            builder.Property(x => x.UsersMa).HasMaxLength(20);
            builder.HasOne(x => x.User)
                .WithMany(x => x.UserCTs)
                .HasForeignKey(x => x.UsersMa)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
