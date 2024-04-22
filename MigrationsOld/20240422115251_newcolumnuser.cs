using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserPreferencesWebApp.Migrations
{
    /// <inheritdoc />
    public partial class newcolumnuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Users",
                newName: "PreferenceValue");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PreferenceValue",
                table: "Users",
                newName: "Value");
        }
    }
}
