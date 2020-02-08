using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class js : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29330863-ac75-4657-a217-958e097283ea", "AQAAAAEAACcQAAAAEDsPTJLJaPnQ9um5B1kr+TBpTQ0wdQMqsn281lJ8kL1DfIAxiEnNRCefaQ3AmpnilQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46d33346-2710-493e-921c-5e02bea4f6e3", "AQAAAAEAACcQAAAAEObCfx1jBk9mnY8xjQ574T9NKrFS70x/N/tvDtl2rc/b71Z8gxXwP7OLG5cFo9fB3w==" });
        }
    }
}
