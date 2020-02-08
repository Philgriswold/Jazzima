using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class attemptingTogetAddButtonWorking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "abd75c8d-7b78-4318-84e4-1584b45e9521", "AQAAAAEAACcQAAAAEAaNdjKLxvYCIJm68Llou62k/kiWjUApeHMsrr7I/N6NKMLGgj0d/U9zl/5Z353NFQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "867df80e-594a-4b9a-b41e-44fec5df42db", "AQAAAAEAACcQAAAAELiUJljl/gTZi7euD7QGPzSx+mv2Cn8AgM6m4wSjEULaQIUEyvxboQ1YEB3m5q06sw==" });
        }
    }
}
