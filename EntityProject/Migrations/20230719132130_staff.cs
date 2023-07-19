using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityProject.Migrations
{
    public partial class staff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "staff",
                columns: table => new
                {
                    staff_id = table.Column<byte>(type: "tinyint", nullable: false),
                    password = table.Column<string>(type: "varchar(40)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    first_name = table.Column<string>(type: "varchar(45)", nullable: false),
                    last_name = table.Column<string>(type: "varchar(45)", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staff", x => x.staff_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "staff");
        }
    }
}
