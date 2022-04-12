using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Base
{
    public class AuditedEntity : BaseEntity
    {
        [Column("f_type")]
        [Comment("тип сущности")]
        [Required]
        public Guid TypeId { get; set; }
    }
}