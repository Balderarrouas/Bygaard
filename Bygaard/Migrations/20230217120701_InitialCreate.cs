using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bygaard.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GrowRooms",
                columns: table => new
                {
                    GrowRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfTrolleys = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrowRooms", x => x.GrowRoomId);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockId);
                });

            migrationBuilder.CreateTable(
                name: "Substrates",
                columns: table => new
                {
                    SubstrateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatinName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaysInGrowthPhase = table.Column<int>(type: "int", nullable: false),
                    DaysInOpeningPhase1 = table.Column<int>(type: "int", nullable: false),
                    DaysInOpeningPhase2 = table.Column<int>(type: "int", nullable: false),
                    DaysInHarvestingPhase = table.Column<int>(type: "int", nullable: false),
                    KgsInStock = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Substrates", x => x.SubstrateId);
                    table.ForeignKey(
                        name: "FK_Substrates_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "StockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GrowRooms",
                columns: new[] { "GrowRoomId", "CreatedAt", "DeletedAt", "Name", "NumberOfTrolleys", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a2aa3bda-3255-4ff6-937f-579d71850a0a"), new DateTime(2023, 2, 17, 13, 7, 1, 375, DateTimeKind.Local).AddTicks(5697), null, "1", 16, new DateTime(2023, 2, 17, 13, 7, 1, 377, DateTimeKind.Local).AddTicks(7332) },
                    { new Guid("542d024c-651b-4642-a7d6-433dd2584684"), new DateTime(2023, 2, 17, 13, 7, 1, 377, DateTimeKind.Local).AddTicks(7691), null, "2", 16, new DateTime(2023, 2, 17, 13, 7, 1, 377, DateTimeKind.Local).AddTicks(7701) },
                    { new Guid("613cf80c-75bd-45af-ad33-87ab6c66c07f"), new DateTime(2023, 2, 17, 13, 7, 1, 377, DateTimeKind.Local).AddTicks(7704), null, "3", 16, new DateTime(2023, 2, 17, 13, 7, 1, 377, DateTimeKind.Local).AddTicks(7707) },
                    { new Guid("ddb0750f-a819-430a-9da5-73c36711c7ac"), new DateTime(2023, 2, 17, 13, 7, 1, 377, DateTimeKind.Local).AddTicks(7710), null, "4", 16, new DateTime(2023, 2, 17, 13, 7, 1, 377, DateTimeKind.Local).AddTicks(7711) },
                    { new Guid("41ed5331-e32e-4ff4-97f7-f5a6376320f0"), new DateTime(2023, 2, 17, 13, 7, 1, 377, DateTimeKind.Local).AddTicks(7714), null, "5", 16, new DateTime(2023, 2, 17, 13, 7, 1, 377, DateTimeKind.Local).AddTicks(7716) },
                    { new Guid("b1914f96-425e-4f73-83b7-1d44e0b4b552"), new DateTime(2023, 2, 17, 13, 7, 1, 377, DateTimeKind.Local).AddTicks(7718), null, "6", 16, new DateTime(2023, 2, 17, 13, 7, 1, 377, DateTimeKind.Local).AddTicks(7720) }
                });

            migrationBuilder.InsertData(
                table: "Stock",
                columns: new[] { "StockId", "Name" },
                values: new object[] { new Guid("55ff02c4-50b4-483c-8594-84b2996b667e"), "Main Storage" });

            migrationBuilder.CreateIndex(
                name: "IX_Substrates_StockId",
                table: "Substrates",
                column: "StockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrowRooms");

            migrationBuilder.DropTable(
                name: "Substrates");

            migrationBuilder.DropTable(
                name: "Stock");
        }
    }
}
