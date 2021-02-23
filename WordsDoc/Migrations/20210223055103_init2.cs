using Microsoft.EntityFrameworkCore.Migrations;

namespace WordsDoc.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DefinisionItem_DefinisionResponses_DefinisionResponseWord",
                table: "DefinisionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DefinisionResponses",
                table: "DefinisionResponses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DefinisionItem",
                table: "DefinisionItem");

            migrationBuilder.DropIndex(
                name: "IX_DefinisionItem_DefinisionResponseWord",
                table: "DefinisionItem");

            migrationBuilder.DropColumn(
                name: "Word",
                table: "DefinisionResponses");

            migrationBuilder.DropColumn(
                name: "DefinisionResponseWord",
                table: "DefinisionItem");

            migrationBuilder.RenameTable(
                name: "DefinisionItem",
                newName: "DefinisionItems");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DefinisionResponses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "WordId",
                table: "DefinisionResponses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Definition",
                table: "DefinisionItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DefinisionItems",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DefinisionResponseId",
                table: "DefinisionItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DefinisionResponseId1",
                table: "DefinisionItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DefinisionResponses",
                table: "DefinisionResponses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DefinisionItems",
                table: "DefinisionItems",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DefinisionItems_DefinisionResponseId",
                table: "DefinisionItems",
                column: "DefinisionResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_DefinisionItems_DefinisionResponseId1",
                table: "DefinisionItems",
                column: "DefinisionResponseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_DefinisionItems_DefinisionResponses_DefinisionResponseId",
                table: "DefinisionItems",
                column: "DefinisionResponseId",
                principalTable: "DefinisionResponses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DefinisionItems_DefinisionResponses_DefinisionResponseId1",
                table: "DefinisionItems",
                column: "DefinisionResponseId1",
                principalTable: "DefinisionResponses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DefinisionItems_DefinisionResponses_DefinisionResponseId",
                table: "DefinisionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_DefinisionItems_DefinisionResponses_DefinisionResponseId1",
                table: "DefinisionItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DefinisionResponses",
                table: "DefinisionResponses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DefinisionItems",
                table: "DefinisionItems");

            migrationBuilder.DropIndex(
                name: "IX_DefinisionItems_DefinisionResponseId",
                table: "DefinisionItems");

            migrationBuilder.DropIndex(
                name: "IX_DefinisionItems_DefinisionResponseId1",
                table: "DefinisionItems");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DefinisionResponses");

            migrationBuilder.DropColumn(
                name: "WordId",
                table: "DefinisionResponses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DefinisionItems");

            migrationBuilder.DropColumn(
                name: "DefinisionResponseId",
                table: "DefinisionItems");

            migrationBuilder.DropColumn(
                name: "DefinisionResponseId1",
                table: "DefinisionItems");

            migrationBuilder.RenameTable(
                name: "DefinisionItems",
                newName: "DefinisionItem");

            migrationBuilder.AddColumn<string>(
                name: "Word",
                table: "DefinisionResponses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Definition",
                table: "DefinisionItem",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DefinisionResponseWord",
                table: "DefinisionItem",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DefinisionResponses",
                table: "DefinisionResponses",
                column: "Word");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DefinisionItem",
                table: "DefinisionItem",
                column: "Definition");

            migrationBuilder.CreateIndex(
                name: "IX_DefinisionItem_DefinisionResponseWord",
                table: "DefinisionItem",
                column: "DefinisionResponseWord");

            migrationBuilder.AddForeignKey(
                name: "FK_DefinisionItem_DefinisionResponses_DefinisionResponseWord",
                table: "DefinisionItem",
                column: "DefinisionResponseWord",
                principalTable: "DefinisionResponses",
                principalColumn: "Word",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
