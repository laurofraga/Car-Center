using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCenter.Migrations
{
    /// <inheritdoc />
    public partial class AddNotaRelantionships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Carro_CarroID",
                table: "Nota");

            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Cliente_CompradorID",
                table: "Nota");

            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Vendedor_VendedorID",
                table: "Nota");

            migrationBuilder.RenameColumn(
                name: "VendedorID",
                table: "Nota",
                newName: "VendedorId");

            migrationBuilder.RenameColumn(
                name: "CompradorID",
                table: "Nota",
                newName: "CompradorId");

            migrationBuilder.RenameColumn(
                name: "CarroID",
                table: "Nota",
                newName: "CarroId");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_VendedorID",
                table: "Nota",
                newName: "IX_Nota_VendedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_CompradorID",
                table: "Nota",
                newName: "IX_Nota_CompradorId");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_CarroID",
                table: "Nota",
                newName: "IX_Nota_CarroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Carro_CarroId",
                table: "Nota",
                column: "CarroId",
                principalTable: "Carro",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Cliente_CompradorId",
                table: "Nota",
                column: "CompradorId",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Vendedor_VendedorId",
                table: "Nota",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Carro_CarroId",
                table: "Nota");

            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Cliente_CompradorId",
                table: "Nota");

            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Vendedor_VendedorId",
                table: "Nota");

            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "Nota",
                newName: "VendedorID");

            migrationBuilder.RenameColumn(
                name: "CompradorId",
                table: "Nota",
                newName: "CompradorID");

            migrationBuilder.RenameColumn(
                name: "CarroId",
                table: "Nota",
                newName: "CarroID");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_VendedorId",
                table: "Nota",
                newName: "IX_Nota_VendedorID");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_CompradorId",
                table: "Nota",
                newName: "IX_Nota_CompradorID");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_CarroId",
                table: "Nota",
                newName: "IX_Nota_CarroID");

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Carro_CarroID",
                table: "Nota",
                column: "CarroID",
                principalTable: "Carro",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Cliente_CompradorID",
                table: "Nota",
                column: "CompradorID",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Vendedor_VendedorID",
                table: "Nota",
                column: "VendedorID",
                principalTable: "Vendedor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
