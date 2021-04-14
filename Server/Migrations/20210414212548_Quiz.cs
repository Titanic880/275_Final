using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class Quiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuizId",
                table: "Db_Questions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Db_Questions_QuizId",
                table: "Db_Questions",
                column: "QuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_Db_Questions_Db_Quizzes_QuizId",
                table: "Db_Questions",
                column: "QuizId",
                principalTable: "Db_Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Db_Questions_Db_Quizzes_QuizId",
                table: "Db_Questions");

            migrationBuilder.DropIndex(
                name: "IX_Db_Questions_QuizId",
                table: "Db_Questions");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "Db_Questions");
        }
    }
}
