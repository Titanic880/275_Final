using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class SessionUpdated1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Current_SessionSession_ID",
                table: "Db_Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Session_Conn",
                columns: table => new
                {
                    Session_ID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session_Conn", x => x.Session_ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Db_Users_Current_SessionSession_ID",
                table: "Db_Users",
                column: "Current_SessionSession_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Db_Users_Session_Conn_Current_SessionSession_ID",
                table: "Db_Users",
                column: "Current_SessionSession_ID",
                principalTable: "Session_Conn",
                principalColumn: "Session_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Db_Users_Session_Conn_Current_SessionSession_ID",
                table: "Db_Users");

            migrationBuilder.DropTable(
                name: "Session_Conn");

            migrationBuilder.DropIndex(
                name: "IX_Db_Users_Current_SessionSession_ID",
                table: "Db_Users");

            migrationBuilder.DropColumn(
                name: "Current_SessionSession_ID",
                table: "Db_Users");
        }
    }
}
