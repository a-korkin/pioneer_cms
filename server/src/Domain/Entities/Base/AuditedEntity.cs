using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Admin;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Base
{
    public abstract class AuditedEntity : BaseEntity
    {
        [Column("f_type")]
        [Comment("тип сущности")]
        [Required]
        public Guid TypeId { get; set; }

        public EntityType Type { get; set; }
    }
}