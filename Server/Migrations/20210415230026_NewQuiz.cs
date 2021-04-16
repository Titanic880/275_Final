using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class NewQuiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Db_Questions_Db_Quizzes_QuizId",
                table: "Db_Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Db_Quizzes_Db_Users_CreatorId",
                table: "Db_Quizzes");

            migrationBuilder.DropForeignKey(
                name: "FK_Db_Users_Db_Quizzes_QuizId",
                table: "Db_Users");

            migrationBuilder.DropIndex(
                name: "IX_Db_Users_QuizId",
                table: "Db_Users");

            migrationBuilder.DropIndex(
                name: "IX_Db_Quizzes_CreatorId",
                table: "Db_Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_Db_Questions_QuizId",
                table: "Db_Questions");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "Db_Users");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Db_Quizzes");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "Db_Questions");

            migrationBuilder.AddColumn<string>(
                name: "AccessUsers",
                table: "Db_Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Creator_ID",
                table: "Db_Quizzes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Questions_Str",
                table: "Db_Quizzes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessUsers",
                table: "Db_Quizzes");

            migrationBuilder.DropColumn(
                name: "Creator_ID",
                table: "Db_Quizzes");

            migrationBuilder.DropColumn(
                name: "Questions_Str",
                table: "Db_Quizzes");

            migrationBuilder.AddColumn<int>(
                name: "QuizId",
                table: "Db_Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Db_Quizzes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuizId",
                table: "Db_Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Db_Users_QuizId",
                table: "Db_Users",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Db_Quizzes_CreatorId",
                table: "Db_Quizzes",
                column: "CreatorId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Db_Quizzes_Db_Users_CreatorId",
                table: "Db_Quizzes",
                column: "CreatorId",
                principalTable: "Db_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Db_Users_Db_Quizzes_QuizId",
                table: "Db_Users",
                column: "QuizId",
                principalTable: "Db_Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
