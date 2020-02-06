using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class addedPropertiesToTheViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "438cd24b-1c49-4dc0-bc2b-f931a98c162a", "AQAAAAEAACcQAAAAEMzNxxW0uDvipxT+UrzvcyP77GZlmdP94SjxRBPXAKDqDwA0mGGX9ILOoVrIfX47Dg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7300e984-d538-4192-96c0-0bd06c740f15", "AQAAAAEAACcQAAAAEPzCWcTd+rrHmR22oKLQSVCo5VK+/i/tRCQSXrtQ4oLKD3qpKrFJAd1bTCVe6sUYhw==" });
        }
    }
}
