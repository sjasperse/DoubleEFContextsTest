using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoubleEFContextsTest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModelAs",
                columns: table => new
                {
                    ModelAId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelAs", x => x.ModelAId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelAs");
        }
    }
}
