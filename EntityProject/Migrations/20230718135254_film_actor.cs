using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityProject.Migrations
{
    public partial class film_actor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "film_actor",
                columns: table => new
                {
                    actor_id = table.Column<int>(type: "int", nullable: false),
                    film_id = table.Column<int>(type: "int", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_film_actor", x => new { x.actor_id, x.film_id });
                    table.ForeignKey(
                        name: "FK_film_actor_actor_actor_id",
                        column: x => x.actor_id,
                        principalTable: "actor",
                        principalColumn: "actor_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_film_actor_film_film_id",
                        column: x => x.film_id,
                        principalTable: "film",
                        principalColumn: "film_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_film_actor_film_id",
                table: "film_actor",
                column: "film_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "film_actor");
        }
    }
}
