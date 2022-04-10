using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Attributes;
using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Admin
{
    [Description(schema: "admin", name: "cs_entity_types", title: "типы сущностей")]
    [Comment("типы сущностей")]
    public class EntityType : BaseEntity
    {
        [Column("c_schema")]
        [Comment("схема")]
        [Required]
        public string Schema { get; set; }

        [Column("c_table")]
        [Comment("таблица")]
        [Required]
        public string Table { get; set; }

        [Column("c_title")]
        [Comment("название")]
        [Required]
        public string Title { get; set; }
    }
}