using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "admin");

            migrationBuilder.CreateTable(
                name: "cs_entity_types",
                schema: "admin",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, comment: "идентификатор"),
                    c_schema = table.Column<string>(type: "text", nullable: false, comment: "схема"),
                    c_table = table.Column<string>(type: "text", nullable: false, comment: "таблица"),
                    c_title = table.Column<string>(type: "text", nullable: false, comment: "название")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cs_entity_types", x => x.id);
                },
                comment: "типы сущностей");

            migrationBuilder.CreateTable(
                name: "cd_entities",
                schema: "admin",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, comment: "идентификатор"),
                    f_type = table.Column<Guid>(type: "uuid", nullable: false, comment: "тип сущности")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_entities", x => new { x.id, x.f_type });
                    table.ForeignKey(
                        name: "fk_cd_entities_cs_entity_types_f_type",
                        column: x => x.f_type,
                        principalSchema: "admin",
                        principalTable: "cs_entity_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "сущности");

            migrationBuilder.CreateTable(
                name: "cd_users",
                schema: "admin",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, comment: "идентификатор"),
                    c_username = table.Column<string>(type: "text", nullable: false, comment: "имя пользователя"),
                    c_password = table.Column<string>(type: "text", nullable: false, comment: "пароль"),
                    c_lastname = table.Column<string>(type: "text", nullable: false, comment: "фамилия"),
                    c_firstname = table.Column<string>(type: "text", nullable: false, comment: "имя"),
                    c_middlename = table.Column<string>(type: "text", nullable: false, comment: "отчество"),
                    f_type = table.Column<Guid>(type: "uuid", nullable: false, comment: "тип сущности")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_users", x => x.id);
                    table.ForeignKey(
                        name: "fk_cd_users_cd_entities_entityid_entitytypeid",
                        columns: x => new { x.id, x.f_type },
                        principalSchema: "admin",
                        principalTable: "cd_entities",
                        principalColumns: new[] { "id", "f_type" },
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "пользователи");

            migrationBuilder.CreateIndex(
                name: "ix_cd_entities_f_type",
                schema: "admin",
                table: "cd_entities",
                column: "f_type");

            migrationBuilder.CreateIndex(
                name: "ix_cd_users_id_f_type",
                schema: "admin",
                table: "cd_users",
                columns: new[] { "id", "f_type" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cd_users",
                schema: "admin");

            migrationBuilder.DropTable(
                name: "cd_entities",
                schema: "admin");

            migrationBuilder.DropTable(
                name: "cs_entity_types",
                schema: "admin");
        }
    }
}
