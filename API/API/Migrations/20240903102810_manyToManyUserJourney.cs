using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class manyToManyUserJourney : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journey_User_UserId",
                table: "Journey");

            migrationBuilder.DropIndex(
                name: "IX_Journey_UserId",
                table: "Journey");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Journey");

            migrationBuilder.CreateTable(
                name: "UserJourneys",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    JourneyId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserJourneys", x => new { x.UserId, x.JourneyId });
                    table.ForeignKey(
                        name: "FK_UserJourneys_Journey_JourneyId",
                        column: x => x.JourneyId,
                        principalTable: "Journey",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserJourneys_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserJourneys_JourneyId",
                table: "UserJourneys",
                column: "JourneyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserJourneys");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Journey",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Journey_UserId",
                table: "Journey",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Journey_User_UserId",
                table: "Journey",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
