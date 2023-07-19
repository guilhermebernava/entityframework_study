using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityProject.Migrations
{
    public partial class film : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "film",
                columns: table => new
                {
                    film_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "varchar(255)", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    release_year = table.Column<string>(type: "varchar(4)", nullable: false),
                    length = table.Column<short>(type: "smallint", nullable: false),
                    rating = table.Column<string>(type: "varchar(10)", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_film", x => x.film_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "film");
        }
    }
}
