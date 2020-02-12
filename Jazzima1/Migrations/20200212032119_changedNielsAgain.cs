using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class changedNielsAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 50,
                column: "Name",
                value: "Niels Henning");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbd56e8b-d9e3-4ff7-bc9a-a74b4f712f21", "AQAAAAEAACcQAAAAEMYHWhd1JZMIQ86JZBWGzL9gmNklADO/IAN4MUAuP07i6rYJUjnPVqsPqV7aKOzcGg==" });

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "Niels-Henning Ørsted");
        }
    }
}
