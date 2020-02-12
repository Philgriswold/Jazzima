using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class changedNat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b92a07f1-f33a-4c1b-be87-d17d0fcd5096", "AQAAAAEAACcQAAAAEJ1F0v0kwiXA6FDCSnTtkEwp3ULS4O07Cmo4I81DursEz0XBaRgIf5YE4kpaX0377w==" });

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Nat Adderley");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4174181c-8f38-414b-a0cf-bc070a318d44", "AQAAAAEAACcQAAAAEAcdtyYF2RLUgfkSCmkVttRW6NgqL2JnDZCr395yFjlQwpViwCWsVFp1hYaI1by3hg==" });

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Cannonball Adderley");
        }
    }
}
