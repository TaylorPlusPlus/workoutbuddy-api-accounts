using Microsoft.EntityFrameworkCore.Migrations;

namespace storage.Migrations
{
    public partial class CardModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    EnitityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManaCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PowerToughness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.EnitityId);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "EnitityId", "CardType", "ImagePath", "ManaCost", "Name", "PowerToughness" },
                values: new object[] { 1, "Instant", "https://www.google.com/search?tbs=sbi:AMhZZivdILz9U0HsPhVAibP0jYIrjMxd8mFfMqs4fJyBH5hDBD8PvaTs3vbffBYMAsMRTysDIfxko5FG04feQrF4Px7dtvvCXJmr0_1NZDX_1NfJAKpMYRto_14Cu--Lktu1nT2kFB5OFshEvyc9QMJsFMioUSxfwxXY0jJEeGnNsRFJn8LsKzU3Y3L-FsiZ6q2oikJhMMxNQHZrhghNbXIzkXP0eSKZRujSm19dXWjO8aydqb300XNbUFev3ZojsE8wRs2wo-ecol1NyJLeOX0l3_1PNld3uankMqDgMAqthmqACqt8c7qFn7jN84mTiADso-2KFlP5gUXRewCKB9M0YbNF2NuyCbdm6FkmyKVdYjzBKCEB7NKMyzuXKlzfV_1OaFipiYGCxR4ZO99jMwOR8YYPQHD3juzEHzw", "R", "Lightning Bolt", "N/A" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
