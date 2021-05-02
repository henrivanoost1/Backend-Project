using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend_Project.Migrations
{
    public partial class negende : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RegioverantwoordelijkeAfdeling",
                columns: new[] { "AfdelingId", "RegioverantwoordelijkeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "RegioverantwoordelijkeAfdeling",
                keyColumns: new[] { "AfdelingId", "RegioverantwoordelijkeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "RegioverantwoordelijkeAfdeling",
                keyColumns: new[] { "AfdelingId", "RegioverantwoordelijkeId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "RegioverantwoordelijkeAfdeling",
                keyColumns: new[] { "AfdelingId", "RegioverantwoordelijkeId" },
                keyValues: new object[] { 3, 2 });
        }
    }
}
