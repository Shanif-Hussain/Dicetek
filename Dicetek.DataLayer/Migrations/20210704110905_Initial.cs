using Microsoft.EntityFrameworkCore.Migrations;

namespace Dicetek.DataLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    emailId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    mobileNo = table.Column<long>(nullable: false),
                    creditCard = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ccExpiryDate = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    ccv = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registers");
        }
    }
}
