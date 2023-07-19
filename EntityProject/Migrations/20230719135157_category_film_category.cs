using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityProject.Migrations
{
    public partial class category_film_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    category_id = table.Column<byte>(type: "tinyint", nullable: false),
                    name = table.Column<string>(type: "varchar(25)", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "film_category",
                columns: table => new
                {
                    category_id = table.Column<byte>(type: "tinyint", nullable: false),
                    film_id = table.Column<int>(type: "int", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_film_category", x => new { x.category_id, x.film_id });
                    table.ForeignKey(
                        name: "FK_film_category_category_category_id",
                        column: x => x.category_id,
                        principalTable: "category",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_film_category_film_film_id",
                        column: x => x.film_id,
                        principalTable: "film",
                        principalColumn: "film_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_film_category_film_id",
                table: "film_category",
                column: "film_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "film_category");

            migrationBuilder.DropTable(
                name: "category");
        }
    }
}
