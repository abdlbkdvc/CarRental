using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Banner1Changed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Banner1s",
                newName: "ImageUrl2");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl1",
                table: "Banner1s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl1",
                table: "Banner1s");

            migrationBuilder.RenameColumn(
                name: "ImageUrl2",
                table: "Banner1s",
                newName: "ImageUrl");
        }
    }
}
