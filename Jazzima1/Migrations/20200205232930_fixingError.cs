using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class fixingError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6bb21be6-4681-4067-8884-1f60cf92cb72", "AQAAAAEAACcQAAAAEC4KJlmt40vDcQmdG2oOmOm5Z6fyMQzGSR2uXNjTd9sl2KmrlxftupVxkvkKPWR2OQ==" });

            migrationBuilder.InsertData(
                table: "Musician",
                columns: new[] { "Id", "Instrument", "InstrumentTypeId", "Name" },
                values: new object[,]
                {
                    { 18, "drums", 4, "Philly Joe Jones" },
                    { 19, "bass", 3, "Paul Chambers" },
                    { 20, "piano", 2, "Kenny Drew" },
                    { 21, "trombone", 1, "Curtis Fuller" },
                    { 22, "trumpet", 1, "Lee Morgan" },
                    { 23, "tenor saxophone", 1, "John Coltrane" }
                });

            migrationBuilder.InsertData(
                table: "MusicianAlbum",
                columns: new[] { "Id", "AlbumId", "MusicianId" },
                values: new object[,]
                {
                    { 22, 5, 23 },
                    { 23, 5, 21 },
                    { 24, 5, 20 },
                    { 25, 5, 22 },
                    { 26, 5, 19 },
                    { 27, 5, 18 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MusicianAlbum",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba7cc1cd-45e8-477e-b97a-3957ffa50fca", "AQAAAAEAACcQAAAAEJtWI9vCgrqWbMDYV4zJE8LXjCvrxdOvoi6tY2+/zc0rrpuZs5KiIzdKu7izr3HUhA==" });
        }
    }
}
