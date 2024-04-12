using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiRelacionamentos.Repository.Migrations
{
    /// <inheritdoc />
    public partial class statusItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "tb_Item");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "tb_Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
