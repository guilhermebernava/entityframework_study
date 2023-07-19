using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityProject.Migrations
{
    public partial class customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    customer_id = table.Column<byte>(type: "tinyint", nullable: false),
                    first_name = table.Column<string>(type: "varchar(45)", nullable: false),
                    last_name = table.Column<string>(type: "varchar(45)", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.customer_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer");
        }
    }
}
