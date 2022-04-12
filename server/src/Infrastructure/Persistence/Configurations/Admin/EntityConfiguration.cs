using Domain.Entities.Admin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Admin
{
    public class EntityConfiguration : IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> builder)
        {
            builder.HasKey(p => new { p.Id, p.TypeId });

            builder
                .HasOne<EntityType>(p => p.Type)
                .WithMany()
                .HasForeignKey(p => p.TypeId);
        }
    }
}