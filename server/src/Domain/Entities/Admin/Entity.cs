using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Attributes;
using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Admin
{
    [Description(schema: "admin", name: "cd_entities", title: "сущности")]
    [Comment("сущности")]
    public class Entity : AuditedEntity
    {
        public EntityType Type { get; set; }
    }
}