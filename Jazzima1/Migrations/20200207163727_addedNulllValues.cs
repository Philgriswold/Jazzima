using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class addedNulllValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "867df80e-594a-4b9a-b41e-44fec5df42db", "AQAAAAEAACcQAAAAELiUJljl/gTZi7euD7QGPzSx+mv2Cn8AgM6m4wSjEULaQIUEyvxboQ1YEB3m5q06sw==" });

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "555010c1-5628-4e60-9189-4a05f21f12be", "AQAAAAEAACcQAAAAEEtW3GHlmLgIMVPZpc2KsJ0m/shJilm0kB1/ywdCLAQA3t1PHznpsivPG6E81u9xmQ==" });

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "(null)");

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "(null)");

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "(null)");

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "(null)");
        }
    }
}
