using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class UpdatedQuestionNQuiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accessiblity",
                table: "Db_Questions");

            migrationBuilder.AddColumn<bool>(
                name: "Is_Host",
                table: "Session_Conn",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "QuizId",
                table: "Db_Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Accessiblity",
                table: "Db_Quizzes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Db_Quizzes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Db_Users_QuizId",
                table: "Db_Users",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Db_Quizzes_CreatorId",
                table: "Db_Quizzes",
                column: "CreatorId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Is_Host",
                table: "Session_Conn");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "Db_Users");

            migrationBuilder.DropColumn(
                name: "Accessiblity",
                table: "Db_Quizzes");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Db_Quizzes");

            migrationBuilder.AddColumn<bool>(
                name: "Accessiblity",
                table: "Db_Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
