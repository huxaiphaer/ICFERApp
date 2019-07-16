using Microsoft.EntityFrameworkCore.Migrations;

namespace ICFERApp.Data.Migrations
{
    public partial class modifytables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentRegNo",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentRegNo",
                table: "Students");
        }
    }
}
