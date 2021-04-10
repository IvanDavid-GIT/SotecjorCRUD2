using Microsoft.EntityFrameworkCore.Migrations;

namespace SotecjorCRUD2.Migrations
{
    public partial class CreaciónTablaMaterialDetalleyajustesbasicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materiales_categoriaMateriales_CategoriaId",
                table: "Materiales");

            migrationBuilder.DropIndex(
                name: "IX_Materiales_CategoriaId",
                table: "Materiales");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Materiales");

            migrationBuilder.CreateTable(
                name: "MaterialDetalle",
                columns: table => new
                {
                    MaterialDetalleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialId = table.Column<int>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false),
                    CategoriaMaterialCategoriaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDetalle", x => x.MaterialDetalleId);
                    table.ForeignKey(
                        name: "FK_MaterialDetalle_categoriaMateriales_CategoriaMaterialCategoriaId",
                        column: x => x.CategoriaMaterialCategoriaId,
                        principalTable: "categoriaMateriales",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialDetalle_Materiales_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materiales",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDetalle_CategoriaMaterialCategoriaId",
                table: "MaterialDetalle",
                column: "CategoriaMaterialCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDetalle_MaterialId",
                table: "MaterialDetalle",
                column: "MaterialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialDetalle");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Materiales",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
