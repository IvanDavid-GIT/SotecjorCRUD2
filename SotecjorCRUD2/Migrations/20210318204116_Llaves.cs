using Microsoft.EntityFrameworkCore.Migrations;

namespace SotecjorCRUD2.Migrations
{
    public partial class Llaves : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaMaterialCategoriaId",
                table: "Materiales",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materiales_CategoriaMaterialCategoriaId",
                table: "Materiales",
                column: "CategoriaMaterialCategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materiales_categoriaMateriales_CategoriaMaterialCategoriaId",
                table: "Materiales",
                column: "CategoriaMaterialCategoriaId",
                principalTable: "categoriaMateriales",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materiales_categoriaMateriales_CategoriaMaterialCategoriaId",
                table: "Materiales");

            migrationBuilder.DropIndex(
                name: "IX_Materiales_CategoriaMaterialCategoriaId",
                table: "Materiales");

            migrationBuilder.DropColumn(
                name: "CategoriaMaterialCategoriaId",
                table: "Materiales");
        }
    }
}
