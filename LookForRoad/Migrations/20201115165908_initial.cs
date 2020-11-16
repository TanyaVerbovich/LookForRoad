using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LookForRoad.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Road",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowManyPlaces = table.Column<int>(type: "int", nullable: false),
                    place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datafrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Telephone = table.Column<long>(type: "bigint", nullable: false),
                    isFav = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Road", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Road");
        }
    }
}
