using Microsoft.EntityFrameworkCore.Migrations;

namespace WordsDoc.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.CreateTable(
                name: "DefinisionResponses",
                columns: table => new
                {
                    Word = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefinisionResponses", x => x.Word);
                });

            migrationBuilder.CreateTable(
                name: "DefinisionItem",
                columns: table => new
                {
                    Definition = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartOfSpeech = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    DefinisionResponseWord = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefinisionItem", x => x.Definition);
                    table.ForeignKey(
                        name: "FK_DefinisionItem_DefinisionResponses_DefinisionResponseWord",
                        column: x => x.DefinisionResponseWord,
                        principalTable: "DefinisionResponses",
                        principalColumn: "Word",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DefinisionItem_DefinisionResponseWord",
                table: "DefinisionItem",
                column: "DefinisionResponseWord");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefinisionItem");

            migrationBuilder.DropTable(
                name: "DefinisionResponses");

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Word = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Word);
                });
        }
    }
}
