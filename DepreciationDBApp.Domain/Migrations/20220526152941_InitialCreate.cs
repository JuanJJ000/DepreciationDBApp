using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DepreciationDBApp.Domain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    amount = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    amountResidual = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Terms = table.Column<int>(type: "int", nullable: false),
                    code = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    names = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    lastnames = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    address = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    phone = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    dni = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AssetEmployee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assetId = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetEmployee", x => x.id);
                    table.ForeignKey(
                        name: "fk_asset",
                        column: x => x.assetId,
                        principalTable: "Asset",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_employee",
                        column: x => x.employeeId,
                        principalTable: "Employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetEmployee_assetId",
                table: "AssetEmployee",
                column: "assetId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetEmployee_employeeId",
                table: "AssetEmployee",
                column: "employeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetEmployee");

            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
