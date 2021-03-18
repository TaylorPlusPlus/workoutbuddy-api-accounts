using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace storage.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    EnitityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.EnitityId);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "EnitityId", "DateJoined", "Email", "FirstName", "LastName" },
                values: new object[] { -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor@live.com", "Taylor", "Stoltzfus" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "EnitityId", "DateJoined", "Email", "FirstName", "LastName" },
                values: new object[] { -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faker@live.com", "James", "Stoltzfus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
