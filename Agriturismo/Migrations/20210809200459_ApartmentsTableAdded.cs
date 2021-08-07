using Microsoft.EntityFrameworkCore.Migrations;

namespace Agriturismo.Migrations
{
    public partial class ApartmentsTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appartaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_It = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_Us = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoubleBed = table.Column<int>(type: "int", nullable: true),
                    ExtraBed = table.Column<int>(type: "int", nullable: true),
                    SofàBed = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appartaments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appartaments");
        }
    }
}
