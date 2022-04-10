using Domain.Entities.Admin;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces 
{
    public interface IApplicationDbContext
    {
        DbSet<EntityType> EntityTypes { get; }
        DbSet<Entity> Entities { get; }
    }
}