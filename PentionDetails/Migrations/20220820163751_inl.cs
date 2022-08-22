using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PentionDetails.Migrations
{
    public partial class inl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcessPensions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aadhar = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    PAN = table.Column<string>(nullable: true),
                    SalaryEarned = table.Column<decimal>(nullable: false),
                    Allowances = table.Column<decimal>(nullable: false),
                    PensionType = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    BankType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessPensions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcessPensions");
        }
    }
}
