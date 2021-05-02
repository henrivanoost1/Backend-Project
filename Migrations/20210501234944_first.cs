using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend_Project.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gewesten",
                columns: table => new
                {
                    GewestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gewesten", x => x.GewestId);
                });

            migrationBuilder.CreateTable(
                name: "Afdelingen",
                columns: table => new
                {
                    AfdelingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gemeente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GewestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afdelingen", x => x.AfdelingId);
                    table.ForeignKey(
                        name: "FK_Afdelingen_Gewesten_GewestId",
                        column: x => x.GewestId,
                        principalTable: "Gewesten",
                        principalColumn: "GewestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regioverantwoordelijken",
                columns: table => new
                {
                    RegioverantwoordelijkeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GewestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regioverantwoordelijken", x => x.RegioverantwoordelijkeId);
                    table.ForeignKey(
                        name: "FK_Regioverantwoordelijken_Gewesten_GewestId",
                        column: x => x.GewestId,
                        principalTable: "Gewesten",
                        principalColumn: "GewestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leden",
                columns: table => new
                {
                    LidId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    AfdelingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leden", x => x.LidId);
                    table.ForeignKey(
                        name: "FK_Leden_Afdelingen_AfdelingId",
                        column: x => x.AfdelingId,
                        principalTable: "Afdelingen",
                        principalColumn: "AfdelingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegioverantwoordelijkeAfdeling",
                columns: table => new
                {
                    RegioverantwoordelijkeId = table.Column<int>(type: "int", nullable: false),
                    AfdelingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegioverantwoordelijkeAfdeling", x => new { x.RegioverantwoordelijkeId, x.AfdelingId });
                    table.ForeignKey(
                        name: "FK_RegioverantwoordelijkeAfdeling_Afdelingen_AfdelingId",
                        column: x => x.AfdelingId,
                        principalTable: "Afdelingen",
                        principalColumn: "AfdelingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegioverantwoordelijkeAfdeling_Regioverantwoordelijken_RegioverantwoordelijkeId",
                        column: x => x.RegioverantwoordelijkeId,
                        principalTable: "Regioverantwoordelijken",
                        principalColumn: "RegioverantwoordelijkeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Gewesten",
                columns: new[] { "GewestId", "Name" },
                values: new object[] { 1, "West-Vlaanderen" });

            migrationBuilder.InsertData(
                table: "Gewesten",
                columns: new[] { "GewestId", "Name" },
                values: new object[] { 2, "Oost-Vlaanderen" });

            migrationBuilder.InsertData(
                table: "Gewesten",
                columns: new[] { "GewestId", "Name" },
                values: new object[] { 3, "Brussel" });

            migrationBuilder.InsertData(
                table: "Afdelingen",
                columns: new[] { "AfdelingId", "Gemeente", "GewestId", "Name" },
                values: new object[,]
                {
                    { 4, "Brugge", 1, "KAJ Brugge" },
                    { 5, "Waregem", 1, "KAJ Waregem" },
                    { 6, "Roeselare", 1, "KAmeleJon Roeselare" },
                    { 1, "Machelen", 2, "KAJ Machelen" },
                    { 2, "Merelbeke", 2, "KAJ Merelbeke" },
                    { 3, "Merelbeke", 2, "KAJ Bottelaere" },
                    { 7, "Sint-Pieters-Woluwe", 3, "KAJ Don Bosco" },
                    { 8, "Lajet", 3, "KAJ Lajet" },
                    { 9, "Brussel", 3, "KAJ De Mug" }
                });

            migrationBuilder.InsertData(
                table: "Regioverantwoordelijken",
                columns: new[] { "RegioverantwoordelijkeId", "Age", "Email", "FirstName", "GewestId", "Name" },
                values: new object[,]
                {
                    { 3, 24, "anke.cloet@kaj.be", "Anke", 1, "Cloet" },
                    { 4, 25, "lien.vanhooft@kaj.be", "Lien", 1, "Vanhoof" },
                    { 1, 23, "lina.sorovojo@kaj.be", "Lina", 2, "Sorovojo" },
                    { 2, 26, "coordinator@kaj.be", "Dries", 2, "Van Rechem" }
                });

            migrationBuilder.InsertData(
                table: "Leden",
                columns: new[] { "LidId", "AfdelingId", "Age", "FirstName", "Name" },
                values: new object[,]
                {
                    { 1, 1, 20, "Henri", "Van Oost" },
                    { 2, 1, 22, "Margaux", "Van Oost" },
                    { 3, 1, 20, "Simon", "De Cocker" },
                    { 4, 2, 19, "Ina", "Van Langenhove" },
                    { 5, 2, 20, "Britt", "Tranchet" },
                    { 6, 2, 16, "Evy", "Van Langenhove" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Afdelingen_GewestId",
                table: "Afdelingen",
                column: "GewestId");

            migrationBuilder.CreateIndex(
                name: "IX_Leden_AfdelingId",
                table: "Leden",
                column: "AfdelingId");

            migrationBuilder.CreateIndex(
                name: "IX_RegioverantwoordelijkeAfdeling_AfdelingId",
                table: "RegioverantwoordelijkeAfdeling",
                column: "AfdelingId");

            migrationBuilder.CreateIndex(
                name: "IX_Regioverantwoordelijken_GewestId",
                table: "Regioverantwoordelijken",
                column: "GewestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leden");

            migrationBuilder.DropTable(
                name: "RegioverantwoordelijkeAfdeling");

            migrationBuilder.DropTable(
                name: "Afdelingen");

            migrationBuilder.DropTable(
                name: "Regioverantwoordelijken");

            migrationBuilder.DropTable(
                name: "Gewesten");
        }
    }
}
