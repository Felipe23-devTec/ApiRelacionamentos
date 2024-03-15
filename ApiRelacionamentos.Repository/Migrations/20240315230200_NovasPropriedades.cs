using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiRelacionamentos.Repository.Migrations
{
    /// <inheritdoc />
    public partial class NovasPropriedades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "tb_Pedidos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tb_Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "tb_Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "tb_Pedidos");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "tb_Cliente");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "tb_Cliente");
        }
    }
}
