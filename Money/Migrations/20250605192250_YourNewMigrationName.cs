using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Money.Migrations
{
    /// <inheritdoc />
    public partial class YourNewMigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Transactions",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "Confirmed",
                table: "Transactions",
                newName: "ConfirmedByB");

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmedByA",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmedByA",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Transactions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ConfirmedByB",
                table: "Transactions",
                newName: "Confirmed");
        }
    }
}
