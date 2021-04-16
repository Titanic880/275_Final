using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class ScoringUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Current_Score",
                table: "Db_Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wrong_Score",
                table: "Db_Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Current_Score",
                table: "Db_Users");

            migrationBuilder.DropColumn(
                name: "Wrong_Score",
                table: "Db_Users");
        }
    }
}
