using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quill_Lite_App.Migrations
{
    /// <inheritdoc />
    public partial class DesignCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Design",
                table: "Quill",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Design",
                table: "Quill");
        }
    }
}
