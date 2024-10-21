using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmableQuishpePromBurgers.Migrations
{
    /// <inheritdoc />
    public partial class SegundoCambio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promo",
                columns: table => new
                {
                    Promoid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaPromo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Burgerid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promo", x => x.Promoid);
                    table.ForeignKey(
                        name: "FK_Promo_Burger_Burgerid",
                        column: x => x.Burgerid,
                        principalTable: "Burger",
                        principalColumn: "Burgerid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promo_Burgerid",
                table: "Promo",
                column: "Burgerid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promo");
        }
    }
}
