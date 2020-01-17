using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BizCraftCrudAP.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(maxLength: 300, nullable: false),
                    Fullname = table.Column<string>(maxLength: 100, nullable: false),
                    Position = table.Column<string>(maxLength: 100, nullable: false),
                    Facelogo = table.Column<string>(maxLength: 150, nullable: false),
                    Twitlogo = table.Column<string>(maxLength: 150, nullable: false),
                    Googlogo = table.Column<string>(maxLength: 150, nullable: false),
                    Linkelogo = table.Column<string>(maxLength: 150, nullable: false),
                    Otherlogo = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Facelogo", "Fullname", "Googlogo", "Image", "Linkelogo", "Otherlogo", "Position", "Twitlogo" },
                values: new object[,]
                {
                    { 1, "<i class='fa fa - facebook'></i>", "<h3>Vosgi Varduhi</h3>", "<i class='fa fa-google-plus'></i>", "woman1.jpg", "<i class='fa fa-linkedin'></i>", "<i class='fa fa-dribbble'></i>", "<p>Web Designer</p>", "<i class='fa fa - twitter'></i>" },
                    { 2, "<i class='fa fa - facebook'></i>", "<h3>Robert Aleska</h3>", "<i class='fa fa-google-plus'></i>", "man1.jpg", "<i class='fa fa-linkedin'></i>", "<i class='fa fa-dribbble'></i>", "<p>Developer</p>", "<i class='fa fa - twitter'></i>" },
                    { 3, "<i class='fa fa - facebook'></i>", "<h3>Taline Voski</h3>", "<i class='fa fa-google-plus'></i>", "woman2.jpg", "<i class='fa fa-linkedin'></i>", "<i class='fa fa-dribbble'></i>", "<p>Graphic Designer</p>", "<i class='fa fa - twitter'></i>" },
                    { 4, "<i class='fa fa - facebook'></i>", "<h3>Alban Spencer</h3>", "<i class='fa fa-google-plus'></i>", "man22.jpg", "<i class='fa fa-linkedin'></i>", "<i class='fa fa-dribbble'></i>", "<p>Junior Developer</p>", "<i class='fa fa - twitter'></i>" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
