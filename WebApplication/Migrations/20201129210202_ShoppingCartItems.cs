using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class ShoppingCartItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCardItems_Materials_MaterialId",
                table: "ShoppingCardItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCardItems",
                table: "ShoppingCardItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCardItems",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCardItems_MaterialId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_MaterialId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Materials_MaterialId",
                table: "ShoppingCartItems",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Materials_MaterialId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "ShoppingCardItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_MaterialId",
                table: "ShoppingCardItems",
                newName: "IX_ShoppingCardItems_MaterialId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCardItems",
                table: "ShoppingCardItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCardItems_Materials_MaterialId",
                table: "ShoppingCardItems",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
