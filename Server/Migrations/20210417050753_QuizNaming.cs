using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class QuizNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Q_Name",
                table: "Db_Quizzes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Q_Name",
                table: "Db_Quizzes");
        }
    }
}
