using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserPreferencesWebApp.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Preferences_PreferenceId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "PreferenceValue",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PreferenceId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Preferences_PreferenceId",
                table: "Users",
                column: "PreferenceId",
                principalTable: "Preferences",
                principalColumn: "PreferenceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Preferences_PreferenceId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "PreferenceValue",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PreferenceId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Preferences_PreferenceId",
                table: "Users",
                column: "PreferenceId",
                principalTable: "Preferences",
                principalColumn: "PreferenceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
