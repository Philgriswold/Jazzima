using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class changedDrummers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7300e984-d538-4192-96c0-0bd06c740f15", "AQAAAAEAACcQAAAAEPzCWcTd+rrHmR22oKLQSVCo5VK+/i/tRCQSXrtQ4oLKD3qpKrFJAd1bTCVe6sUYhw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6bb21be6-4681-4067-8884-1f60cf92cb72", "AQAAAAEAACcQAAAAEC4KJlmt40vDcQmdG2oOmOm5Z6fyMQzGSR2uXNjTd9sl2KmrlxftupVxkvkKPWR2OQ==" });
        }
    }
}
