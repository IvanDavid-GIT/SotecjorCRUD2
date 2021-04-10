using Microsoft.EntityFrameworkCore.Migrations;

namespace SotecjorCRUD2.Migrations
{
    public partial class Todook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialDetalle_categoriaMateriales_CategoriaId",
                table: "MaterialDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialDetalle_Materiales_MaterialId",
                table: "MaterialDetalle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialDetalle",
                table: "MaterialDetalle");

            migrationBuilder.RenameTable(
                name: "MaterialDetalle",
                newName: "MaterialDetalles");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialDetalle_MaterialId",
                table: "MaterialDetalles",
                newName: "IX_MaterialDetalles_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialDetalle_CategoriaId",
                table: "MaterialDetalles",
                newName: "IX_MaterialDetalles_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialDetalles",
                table: "MaterialDetalles",
                column: "MaterialDetalleId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialDetalles_categoriaMateriales_CategoriaId",
                table: "MaterialDetalles",
                column: "CategoriaId",
                principalTable: "categoriaMateriales",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialDetalles_Materiales_MaterialId",
                table: "MaterialDetalles",
                column: "MaterialId",
                principalTable: "Materiales",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialDetalles_categoriaMateriales_CategoriaId",
                table: "MaterialDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialDetalles_Materiales_MaterialId",
                table: "MaterialDetalles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialDetalles",
                table: "MaterialDetalles");

            migrationBuilder.RenameTable(
                name: "MaterialDetalles",
                newName: "MaterialDetalle");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialDetalles_MaterialId",
                table: "MaterialDetalle",
                newName: "IX_MaterialDetalle_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialDetalles_CategoriaId",
                table: "MaterialDetalle",
                newName: "IX_MaterialDetalle_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialDetalle",
                table: "MaterialDetalle",
                column: "MaterialDetalleId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialDetalle_categoriaMateriales_CategoriaId",
                table: "MaterialDetalle",
                column: "CategoriaId",
                principalTable: "categoriaMateriales",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialDetalle_Materiales_MaterialId",
                table: "MaterialDetalle",
                column: "MaterialId",
                principalTable: "Materiales",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
