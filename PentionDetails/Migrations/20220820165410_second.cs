using Microsoft.EntityFrameworkCore.Migrations;

namespace PentionDetails.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProcessPensions",
                table: "ProcessPensions");

            migrationBuilder.RenameTable(
                name: "ProcessPensions",
                newName: "PentionDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PentionDetails",
                table: "PentionDetails",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PentionDetails",
                table: "PentionDetails");

            migrationBuilder.RenameTable(
                name: "PentionDetails",
                newName: "ProcessPensions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProcessPensions",
                table: "ProcessPensions",
                column: "Id");
        }
    }
}
