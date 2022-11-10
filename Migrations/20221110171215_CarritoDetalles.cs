using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce_V2.Migrations
{
    public partial class CarritoDetalles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarritoDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductoId = table.Column<int>(type: "int", nullable: true),
                    Monto = table.Column<int>(type: "int", nullable: false),
                    CarritoId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarritoDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarritoDetalles_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarritoDetalles_ProductoId",
                table: "CarritoDetalles",
                column: "ProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarritoDetalles");
        }
    }
}
