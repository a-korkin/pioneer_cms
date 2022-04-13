using Domain.Entities.Admin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Admin
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasOne<EntityType>(p => p.Type)
                .WithMany()
                .HasForeignKey(p => p.TypeId);

            builder
                .HasOne<Entity>()
                .WithMany()
                .HasForeignKey(p => new { p.Id, p.TypeId });
        }
    }
}