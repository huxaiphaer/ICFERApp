using Microsoft.EntityFrameworkCore.Migrations;

namespace ICFERApp.Data.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guardians_Students_StudentId",
                table: "Guardians");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guardians",
                table: "Guardians");

            migrationBuilder.RenameTable(
                name: "Guardians",
                newName: "Guardian");

            migrationBuilder.RenameIndex(
                name: "IX_Guardians_StudentId",
                table: "Guardian",
                newName: "IX_Guardian_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guardian",
                table: "Guardian",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Guardian_Students_StudentId",
                table: "Guardian",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guardian_Students_StudentId",
                table: "Guardian");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guardian",
                table: "Guardian");

            migrationBuilder.RenameTable(
                name: "Guardian",
                newName: "Guardians");

            migrationBuilder.RenameIndex(
                name: "IX_Guardian_StudentId",
                table: "Guardians",
                newName: "IX_Guardians_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guardians",
                table: "Guardians",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Guardians_Students_StudentId",
                table: "Guardians",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
