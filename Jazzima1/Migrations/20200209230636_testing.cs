using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0411c8e6-1da8-486b-ac9b-7eab9e67dcc5", "AQAAAAEAACcQAAAAECvWQ+lrYIoXBMV4ul/qXynSSnsBHAadTSHGBmUnOTHP4b8pOgXt8w64UXKVIekDpQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d59e46a-e405-4c19-86cb-92ab26df244a", "AQAAAAEAACcQAAAAEClnf6ZrUU+BFU3MTOiO5GQbXbUS9mJGPIALdaBv3gPXa5iDipXyVjlgnlggthqDpg==" });
        }
    }
}
