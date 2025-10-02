using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JudoApp.Migrations
{
    /// <inheritdoc />
    public partial class AddNicUniqueIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NIC",
                table: "Athletes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Athletes_NIC",
                table: "Athletes",
                column: "NIC",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Athletes_NIC",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "NIC",
                table: "Athletes");
        }
    }
}
