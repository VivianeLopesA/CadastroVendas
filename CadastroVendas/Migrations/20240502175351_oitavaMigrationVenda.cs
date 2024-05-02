using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroVendas.Migrations
{
    /// <inheritdoc />
    public partial class oitavaMigrationVenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Cliente_ClienteId",
                table: "Venda");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Funcionario_FuncionarioId",
                table: "Venda");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Produto_ProdutoID",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_ClienteId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_FuncionarioId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_ProdutoID",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "ProdutoID",
                table: "Venda");

            migrationBuilder.AddColumn<string>(
                name: "Cliente",
                table: "Venda",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Funcionario",
                table: "Venda",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Produto",
                table: "Venda",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cliente",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "Funcionario",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "Produto",
                table: "Venda");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoID",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ClienteId",
                table: "Venda",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_FuncionarioId",
                table: "Venda",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ProdutoID",
                table: "Venda",
                column: "ProdutoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Cliente_ClienteId",
                table: "Venda",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Funcionario_FuncionarioId",
                table: "Venda",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "FuncionarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Produto_ProdutoID",
                table: "Venda",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ProdutoID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
