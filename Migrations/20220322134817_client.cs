using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_core.Migrations
{
    public partial class client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<int>(type: "int", nullable: false),
                    IsCommercial = table.Column<int>(type: "int", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(8)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    Street = table.Column<string>(type: "varchar(50)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(8)", nullable: false),
                    Complement = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    District = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Gender = table.Column<string>(type: "varchar(9)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
