using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AroundTheWorld.Migrations
{
    public partial class AddDestinationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Reviews");

            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
                table: "Reviews",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_DestinationId",
                table: "Reviews",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Destinations_DestinationId",
                table: "Reviews",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Destinations_DestinationId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_DestinationId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Reviews",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Reviews",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "City", "Country" },
                values: new object[] { "Gothenburg", "Sweden" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "City", "Country" },
                values: new object[] { "New York", "United States" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "City", "Country" },
                values: new object[] { "Pompeii", "Italy" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "City", "Country" },
                values: new object[] { "York", "England" });
        }
    }
}
