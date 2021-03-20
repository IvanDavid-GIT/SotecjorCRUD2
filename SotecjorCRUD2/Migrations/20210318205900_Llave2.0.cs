using Microsoft.EntityFrameworkCore.Migrations;

namespace SotecjorCRUD2.Migrations
{
    public partial class Llave20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Materiales_CategoriaId",
                table: "Materiales",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materiales_categoriaMateriales_CategoriaId",
                table: "Materiales",
                column: "CategoriaId",
                principalTable: "categoriaMateriales",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materiales_categoriaMateriales_CategoriaId",
                table: "Materiales");

            migrationBuilder.DropIndex(
                name: "IX_Materiales_CategoriaId",
                table: "Materiales");
        }
    }
}
