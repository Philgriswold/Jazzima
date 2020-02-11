using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class updatedDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "877060a1-d72f-428e-8c57-8df40ed2bfeb", "AQAAAAEAACcQAAAAEBydwnWIyS5oMVBM1eTT2ulsUShKQWdrKi+TbMYrFEsRoitP/wl9zOvt5xOiLTyaBA==" });

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 55,
                column: "InstrumentTypeId",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32681c1c-2f00-409f-9a5f-e3842e5c9bc4", "AQAAAAEAACcQAAAAEP2UsJP+WIWf/5ZthhB91AFwTM9NDY/hofvGucXJEMrCJHbcp+uKLjpkF6timl+HUw==" });

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 55,
                column: "InstrumentTypeId",
                value: 1);
        }
    }
}
