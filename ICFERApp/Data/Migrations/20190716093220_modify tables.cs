using Microsoft.EntityFrameworkCore.Migrations;

namespace ICFERApp.Data.Migrations
{
    public partial class modifytables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Parents",
                table: "Parents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guardian",
                table: "Guardian");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parents",
                table: "Parents",
                columns: new[] { "Id", "StudentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guardian",
                table: "Guardian",
                columns: new[] { "Id", "StudentId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Parents",
                table: "Parents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guardian",
                table: "Guardian");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parents",
                table: "Parents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guardian",
                table: "Guardian",
                column: "Id");
        }
    }
}
