using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class updating2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4c066ab-3ce3-44d5-90bb-1e564bf8b7e2", "AQAAAAEAACcQAAAAEK0miC6oMqjFLUqD4zlAQOunZN6dsjsvH+vKsQ3wnj45HP/a/82GRAYAe7P/Jp3dhg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a47cdff6-1bc2-4979-8013-5069dfc18feb", "AQAAAAEAACcQAAAAEOPYEo+lvaXQflpnS0oAV8bRYjefCkEbb5ER1CKy7dZEONaGqqFvrqf16YIs6Oejsw==" });
        }
    }
}
