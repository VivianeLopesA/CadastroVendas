using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroVendas.Migrations
{
    /// <inheritdoc />
    public partial class primeiroMigrationADM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADM",
                columns: table => new
                {
                    ADMId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADMName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADM", x => x.ADMId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADM");
        }
    }
}
