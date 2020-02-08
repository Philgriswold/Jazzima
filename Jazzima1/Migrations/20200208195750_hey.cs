using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class hey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "50041d23-7e82-4143-b5b8-a159e67bac56", "AQAAAAEAACcQAAAAEA7HhUSo+nL3reOZm4eskQh4FhEtft6UFbvH1G0BjSfadsbrSMajBkxQLYPS/FVObA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9a17796-07ad-4026-bf0f-dcd288ce9e1b", "AQAAAAEAACcQAAAAEAnO9n+0kZv2Raoe36y4aq1jDZWcPu9q56zPIotGNRbWlz+TyXyQ6Yv+IDUNNuX+9Q==" });
        }
    }
}
