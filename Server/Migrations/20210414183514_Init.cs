using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Accessiblity = table.Column<bool>(nullable: false),
                    Question_Time = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Db_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Db_Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Db_Quizzes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Db_Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Db_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Db_Questions");

            migrationBuilder.DropTable(
                name: "Db_Quizzes");

            migrationBuilder.DropTable(
                name: "Db_Users");
        }
    }
}
