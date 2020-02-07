using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class addedNullValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "555010c1-5628-4e60-9189-4a05f21f12be", "AQAAAAEAACcQAAAAEEtW3GHlmLgIMVPZpc2KsJ0m/shJilm0kB1/ywdCLAQA3t1PHznpsivPG6E81u9xmQ==" });

            migrationBuilder.InsertData(
                table: "Musician",
                columns: new[] { "Id", "Instrument", "InstrumentTypeId", "Name" },
                values: new object[,]
                {
                    { 30, "horns", 1, "(null)" },
                    { 31, "piano", 2, "(null)" },
                    { 32, "bass", 3, "(null)" },
                    { 33, "druma", 4, "(null)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e65fb911-5173-4d07-bd4b-902477c60ba4", "AQAAAAEAACcQAAAAEGfg8zlO4Rw/seAvU9QHhtO0gjqvoCJIvD4H8PoJsaH2S9K47TbXdCiKxtiowaQLSQ==" });
        }
    }
}
