using Microsoft.EntityFrameworkCore.Migrations;

namespace WordsDoc.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DefinisionResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WordId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefinisionResponses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DefinisionItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartOfSpeech = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefinisionResponseId = table.Column<int>(type: "int", nullable: true),
                    DefinisionResponseId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefinisionItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DefinisionItems_DefinisionResponses_DefinisionResponseId",
                        column: x => x.DefinisionResponseId,
                        principalTable: "DefinisionResponses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DefinisionItems_DefinisionResponses_DefinisionResponseId1",
                        column: x => x.DefinisionResponseId1,
                        principalTable: "DefinisionResponses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DefinisionItems_DefinisionResponseId",
                table: "DefinisionItems",
                column: "DefinisionResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_DefinisionItems_DefinisionResponseId1",
                table: "DefinisionItems",
                column: "DefinisionResponseId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefinisionItems");

            migrationBuilder.DropTable(
                name: "DefinisionResponses");
        }
    }
}
