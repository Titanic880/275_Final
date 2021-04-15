using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Session_Conn",
                columns: table => new
                {
                    Session_ID = table.Column<string>(nullable: false),
                    Is_Host = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session_Conn", x => x.Session_ID);
                });

            migrationBuilder.CreateTable(
                name: "Db_Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vis_Question = table.Column<string>(nullable: true),
                    Vis_Answers_Str = table.Column<string>(nullable: true),
                    Correct_Answers_Str = table.Column<string>(nullable: true),
                    Created_Question = table.Column<DateTime>(nullable: false),
                    Question_Time = table.Column<int>(nullable: false),
                    QuizId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Db_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Db_Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Temp = table.Column<bool>(nullable: false),
                    Current_SessionSession_ID = table.Column<string>(nullable: true),
                    QuizId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Db_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Db_Users_Session_Conn_Current_SessionSession_ID",
                        column: x => x.Current_SessionSession_ID,
                        principalTable: "Session_Conn",
                        principalColumn: "Session_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Db_Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accessiblity = table.Column<bool>(nullable: false),
                    CreatorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Db_Quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Db_Quizzes_Db_Users_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Db_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Db_Questions_QuizId",
                table: "Db_Questions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Db_Quizzes_CreatorId",
                table: "Db_Quizzes",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Db_Users_Current_SessionSession_ID",
                table: "Db_Users",
                column: "Current_SessionSession_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Db_Users_QuizId",
                table: "Db_Users",
                column: "QuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_Db_Questions_Db_Quizzes_QuizId",
                table: "Db_Questions",
                column: "QuizId",
                principalTable: "Db_Quizzes",
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
                name: "FK_Db_Users_Db_Quizzes_QuizId",
                table: "Db_Users");

            migrationBuilder.DropTable(
                name: "Db_Questions");

            migrationBuilder.DropTable(
                name: "Db_Quizzes");

            migrationBuilder.DropTable(
                name: "Db_Users");

            migrationBuilder.DropTable(
                name: "Session_Conn");
        }
    }
}
