using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserPreferencesWebApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateRedo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Preferences_Users_UserId",
                table: "Preferences");

            migrationBuilder.DropIndex(
                name: "IX_Preferences_UserId",
                table: "Preferences");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Preferences");

            migrationBuilder.AddColumn<int>(
                name: "PreferenceId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PreferenceId",
                table: "Users",
                column: "PreferenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Preferences_PreferenceId",
                table: "Users",
                column: "PreferenceId",
                principalTable: "Preferences",
                principalColumn: "PreferenceId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Preferences_PreferenceId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PreferenceId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PreferenceId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Preferences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_UserId",
                table: "Preferences",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Preferences_Users_UserId",
                table: "Preferences",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
