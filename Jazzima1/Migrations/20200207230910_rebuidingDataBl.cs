using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class rebuidingDataBl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b67475b-a7f4-4eea-bcec-689bc1682003", "AQAAAAEAACcQAAAAEG+kFwQi5j2KbO6DMjsn5kcIPemhJMYVbjreusbijDFRxlmddJLAKD/oV75UaX5EFQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ffb2fbc8-4f0c-4a80-a776-216586cb9b19", "AQAAAAEAACcQAAAAEHD5Bj8EN/Iq903Ibg/BWjZI3amG/pU5xG1Gm1G2HboBD1fcJ98Ix1kz77FoLMYoxA==" });
        }
    }
}
