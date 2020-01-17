using Microsoft.EntityFrameworkCore.Migrations;

namespace BizCraftCrudAP.Migrations
{
    public partial class secondary2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Facelogo", "Twitlogo" },
                values: new object[] { "<i class='fa fa-facebook'></i>", "<i class='fa fa-twitter'></i>" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Facelogo", "Twitlogo" },
                values: new object[] { "<i class='fa fa-facebook'></i>", "<i class='fa fa-twitter'></i>" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Facelogo", "Twitlogo" },
                values: new object[] { "<i class='fa fa-facebook'></i>", "<i class='fa fa-twitter'></i>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Facelogo", "Twitlogo" },
                values: new object[] { "<i class='fa fa - facebook'></i>", "<i class='fa fa - twitter'></i>" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Facelogo", "Twitlogo" },
                values: new object[] { "<i class='fa fa - facebook'></i>", "<i class='fa fa - twitter'></i>" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Facelogo", "Twitlogo" },
                values: new object[] { "<i class='fa fa - facebook'></i>", "<i class='fa fa - twitter'></i>" });
        }
    }
}
