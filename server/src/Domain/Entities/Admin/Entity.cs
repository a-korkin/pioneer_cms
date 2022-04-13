using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Attributes;
using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Admin
{
    [Description(schema: "admin", name: "cd_entities", title: "сущности")]
    [Comment("сущности")]
    public class Entity : BaseEntity
    {
        [Column("f_type")]
        [Comment("тип сущности")]
        [Required]
        public Guid TypeId { get; set; }
        
        public EntityType Type { get; set; }
    }
}