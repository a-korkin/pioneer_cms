using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Attributes;
using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Admin
{
    [Description(schema: "admin", name: "cd_users", title: "пользователи")]
    [Comment("пользователи")]
    public class User : AuditedEntity
    {
        [Column("c_username")]
        [Comment("имя пользователя")]
        [Required]
        public string UserName { get; set; }

        [Column("c_password")]
        [Comment("пароль")]
        public string Password { get; set; }

        [Column("c_lastname")]
        [Comment("фамилия")]
        [Required]
        public string LastName { get; set; }

        [Column("c_firstname")]
        [Comment("имя")]
        [Required]
        public string FirstName { get; set; }

        [Column("c_middlename")]
        [Comment("отчество")]
        public string MiddleName { get; set; }

    }
}