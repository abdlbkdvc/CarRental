using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeadBranchOfficeAddress",
                table: "ContactInformations");

            migrationBuilder.RenameColumn(
                name: "ServiceEmail",
                table: "ContactInformations",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ReturnEmail",
                table: "ContactInformations",
                newName: "IconUrl");

            migrationBuilder.RenameColumn(
                name: "HeadOfficeAddress",
                table: "ContactInformations",
                newName: "Address");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ContactInformations",
                newName: "ServiceEmail");

            migrationBuilder.RenameColumn(
                name: "IconUrl",
                table: "ContactInformations",
                newName: "ReturnEmail");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "ContactInformations",
                newName: "HeadOfficeAddress");

            migrationBuilder.AddColumn<string>(
                name: "HeadBranchOfficeAddress",
                table: "ContactInformations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
