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
                    PromoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrpcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaPromo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BurgesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promo", x => x.PromoId);
                    table.ForeignKey(
                        name: "FK_Promo_Burges_BurgesId",
                        column: x => x.BurgesId,
                        principalTable: "Burges",
                        principalColumn: "BurgesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promo_BurgesId",
                table: "Promo",
                column: "BurgesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promo");
        }
    }
}
