using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContentManagementSystem.Models.Configs
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.Username)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(p => p.PasswordHash)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(p => p.PasswordSalt)
                .IsRequired()
                .HasMaxLength(256);

        }
    }
}
