using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend_Project.Migrations
{
    public partial class achtste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RegioverantwoordelijkeAfdeling",
                keyColumns: new[] { "AfdelingId", "RegioverantwoordelijkeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RegioverantwoordelijkeAfdeling",
                keyColumns: new[] { "AfdelingId", "RegioverantwoordelijkeId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "RegioverantwoordelijkeAfdeling",
                keyColumns: new[] { "AfdelingId", "RegioverantwoordelijkeId" },
                keyValues: new object[] { 3, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RegioverantwoordelijkeAfdeling",
                columns: new[] { "AfdelingId", "RegioverantwoordelijkeId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "RegioverantwoordelijkeAfdeling",
                columns: new[] { "AfdelingId", "RegioverantwoordelijkeId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "RegioverantwoordelijkeAfdeling",
                columns: new[] { "AfdelingId", "RegioverantwoordelijkeId" },
                values: new object[] { 3, 1 });
        }
    }
}
