using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiRelacionamentos.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Initialnovo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_Pedidos",
                newName: "IdPedido");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_Cliente",
                newName: "IdCliente");

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.IdItem);
                    table.ForeignKey(
                        name: "FK_Item_tb_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "tb_Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_PedidoId",
                table: "Item",
                column: "PedidoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.RenameColumn(
                name: "IdPedido",
                table: "tb_Pedidos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "tb_Cliente",
                newName: "Id");
        }
    }
}
