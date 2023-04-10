using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessTracker.Migrations
{
    public partial class columnchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Distance",
                table: "FitnessTracker",
                newName: "Distance_km");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Distance_km",
                table: "FitnessTracker",
                newName: "Distance");
        }
    }
}
