using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlatRentService.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlatDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    NumberOfBedRoom = table.Column<int>(type: "int", nullable: false),
                    NumberOfBathRoom = table.Column<int>(type: "int", nullable: false),
                    FlatSize = table.Column<int>(type: "int", nullable: false),
                    IsLiftAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlatDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlatDetails");
        }
    }
}
