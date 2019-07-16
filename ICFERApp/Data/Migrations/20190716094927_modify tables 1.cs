using Microsoft.EntityFrameworkCore.Migrations;

namespace ICFERApp.Data.Migrations
{
    public partial class modifytables1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Parents",
                table: "Parents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guardian",
                table: "Guardian");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Siblings_Id",
                table: "Siblings",
                column: "Id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Parents_Id",
                table: "Parents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parents",
                table: "Parents",
                columns: new[] { "Id", "StudentId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Guardian_Id",
                table: "Guardian",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guardian",
                table: "Guardian",
                columns: new[] { "Id", "StudentId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Education_Id",
                table: "Education",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Siblings_Id",
                table: "Siblings");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Parents_Id",
                table: "Parents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parents",
                table: "Parents");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Guardian_Id",
                table: "Guardian");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guardian",
                table: "Guardian");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Education_Id",
                table: "Education");

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
