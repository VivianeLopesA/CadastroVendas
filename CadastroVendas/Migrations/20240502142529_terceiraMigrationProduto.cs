using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroVendas.Migrations
{
    /// <inheritdoc />
    public partial class terceiraMigrationProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "Produto",
                newName: "Quantidade");

            migrationBuilder.AlterColumn<int>(
                name: "Quantidade",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecoUnidade",
                table: "Produto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoUnidade",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "Produto",
                newName: "quantidade");

            migrationBuilder.AlterColumn<int>(
                name: "quantidade",
                table: "Produto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
