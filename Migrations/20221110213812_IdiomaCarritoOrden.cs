using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce_V2.Migrations
{
    public partial class IdiomaCarritoOrden : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Ordenes_OrderId",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ordenes",
                table: "Ordenes");

            migrationBuilder.RenameTable(
                name: "Ordenes",
                newName: "Orders");

            migrationBuilder.RenameColumn(
                name: "Monto",
                table: "ShoppingCartItems",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "CarritoId",
                table: "ShoppingCartItems",
                newName: "ShoppingCartId");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "OrderItems",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Monto",
                table: "OrderItems",
                newName: "Amount");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Ordenes");

            migrationBuilder.RenameColumn(
                name: "ShoppingCartId",
                table: "ShoppingCartItems",
                newName: "CarritoId");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "ShoppingCartItems",
                newName: "Monto");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "OrderItems",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "OrderItems",
                newName: "Monto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ordenes",
                table: "Ordenes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Ordenes_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Ordenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
