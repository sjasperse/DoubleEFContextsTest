using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoubleEFContextsTest.Migrations.FeatureBDb
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModelBs",
                columns: table => new
                {
                    ModelBId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelBs", x => x.ModelBId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelBs");
        }
    }
}
