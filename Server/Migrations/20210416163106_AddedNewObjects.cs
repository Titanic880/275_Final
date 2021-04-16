using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class AddedNewObjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Db_Users_Session_Conn_Current_SessionSession_ID",
                table: "Db_Users");

            migrationBuilder.DropTable(
                name: "Session_Conn");

            migrationBuilder.CreateTable(
                name: "Session_",
                columns: table => new
                {
                    Session_ID = table.Column<string>(nullable: false),
                    Is_Host = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session_", x => x.Session_ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Db_Users_Session__Current_SessionSession_ID",
                table: "Db_Users",
                column: "Current_SessionSession_ID",
                principalTable: "Session_",
                principalColumn: "Session_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Db_Users_Session__Current_SessionSession_ID",
                table: "Db_Users");

            migrationBuilder.DropTable(
                name: "Session_");

            migrationBuilder.CreateTable(
                name: "Session_Conn",
                columns: table => new
                {
                    Session_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Is_Host = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session_Conn", x => x.Session_ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Db_Users_Session_Conn_Current_SessionSession_ID",
                table: "Db_Users",
                column: "Current_SessionSession_ID",
                principalTable: "Session_Conn",
                principalColumn: "Session_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
