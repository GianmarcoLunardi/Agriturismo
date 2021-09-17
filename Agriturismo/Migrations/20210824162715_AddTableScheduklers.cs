using Microsoft.EntityFrameworkCore.Migrations;


// This Transaction Add The Table Scheduler


namespace Agriturismo.Migrations
{
    public partial class AddTableScheduklers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppartamentVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_It = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_Us = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoubleBed = table.Column<int>(type: "int", nullable: false),
                    ExtraBed = table.Column<int>(type: "int", nullable: false),
                    SofàBed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppartamentVM", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppartamentVM");
        }
    }
}
