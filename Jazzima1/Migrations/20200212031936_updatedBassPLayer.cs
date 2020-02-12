using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class updatedBassPLayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbd56e8b-d9e3-4ff7-bc9a-a74b4f712f21", "AQAAAAEAACcQAAAAEMYHWhd1JZMIQ86JZBWGzL9gmNklADO/IAN4MUAuP07i6rYJUjnPVqsPqV7aKOzcGg==" });

            migrationBuilder.UpdateData(
                table: "Musician",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "Niels-Henning Ørsted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 50,
                column: "Name",
                value: "Niels-Henning Ørsted Pedersen");
        }
    }
}
