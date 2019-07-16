using Microsoft.EntityFrameworkCore.Migrations;

namespace ICFERApp.Data.Migrations
{
    public partial class addmoretables6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Siblings",
                table: "Siblings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Siblings",
                table: "Siblings",
                columns: new[] { "Id", "StudentId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Siblings",
                table: "Siblings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Siblings",
                table: "Siblings",
                column: "Id");
        }
    }
}
