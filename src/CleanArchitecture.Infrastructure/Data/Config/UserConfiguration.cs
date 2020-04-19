using CleanArchitecture.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Data.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(t => t.Name)
                .IsRequired();

            builder.OwnsOne(u => u.Credentials, a => {
                a.WithOwner();

                a.Property(a => a.Username)
                    .HasMaxLength(30)
                    .IsRequired();

                a.Property(a => a.Password)
                    .HasMaxLength(20)
                    .IsRequired();
            });

            builder.OwnsOne(t => t.Email, a =>
            {
                a.WithOwner();

                a.Property(a => a.Address)
                    .IsRequired();
            });
        }
    }
}
