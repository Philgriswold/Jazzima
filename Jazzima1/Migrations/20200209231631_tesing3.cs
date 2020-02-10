using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class tesing3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5f14daf-baed-4d19-b31b-29e36564e894", "AQAAAAEAACcQAAAAELZSUEa2h6so+CJtRL8z5flES6C8ruPbrtFgPAl2RFZ9wReCDu4GyRQI6mLWD1tSQg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0411c8e6-1da8-486b-ac9b-7eab9e67dcc5", "AQAAAAEAACcQAAAAECvWQ+lrYIoXBMV4ul/qXynSSnsBHAadTSHGBmUnOTHP4b8pOgXt8w64UXKVIekDpQ==" });
        }
    }
}
