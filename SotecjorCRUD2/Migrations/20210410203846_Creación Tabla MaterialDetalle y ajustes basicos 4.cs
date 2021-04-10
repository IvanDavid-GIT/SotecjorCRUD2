using Microsoft.EntityFrameworkCore.Migrations;

namespace SotecjorCRUD2.Migrations
{
    public partial class CreaciónTablaMaterialDetalleyajustesbasicos4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialDetalle_categoriaMateriales_CategoriaMaterialCategoriaId",
                table: "MaterialDetalle");

            migrationBuilder.DropIndex(
                name: "IX_MaterialDetalle_CategoriaMaterialCategoriaId",
                table: "MaterialDetalle");

            migrationBuilder.DropColumn(
                name: "CategoriaMaterialCategoriaId",
                table: "MaterialDetalle");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDetalle_CategoriaId",
                table: "MaterialDetalle",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialDetalle_categoriaMateriales_CategoriaId",
                table: "MaterialDetalle",
                column: "CategoriaId",
                principalTable: "categoriaMateriales",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialDetalle_categoriaMateriales_CategoriaId",
                table: "MaterialDetalle");

            migrationBuilder.DropIndex(
                name: "IX_MaterialDetalle_CategoriaId",
                table: "MaterialDetalle");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaMaterialCategoriaId",
                table: "MaterialDetalle",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDetalle_CategoriaMaterialCategoriaId",
                table: "MaterialDetalle",
                column: "CategoriaMaterialCategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialDetalle_categoriaMateriales_CategoriaMaterialCategoriaId",
                table: "MaterialDetalle",
                column: "CategoriaMaterialCategoriaId",
                principalTable: "categoriaMateriales",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
