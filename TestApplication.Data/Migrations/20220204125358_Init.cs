using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApplication.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Username" },
                values: new object[] { new Guid("037870f4-1087-47d8-8dc7-cfecaa19a6ac"), "Hash" });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Username" },
                values: new object[] { new Guid("67fb9aad-e0f5-45a6-9a2d-8686e0e07fec"), "Denis" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserEntities");
        }
    }
}
