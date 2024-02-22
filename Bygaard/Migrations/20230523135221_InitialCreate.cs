using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bygaard.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    BatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Substrate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KilosOfSubstrate = table.Column<double>(type: "float", nullable: false),
                    KilosOfProduce = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.BatchId);
                });

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
                name: "StockItems",
                columns: table => new
                {
                    StockItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubstrateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KilosOfProduce = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockItems", x => x.StockItemId);
                });

            migrationBuilder.CreateTable(
                name: "Substrates",
                columns: table => new
                {
                    SubstrateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatinName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaysToGrow = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Substrates", x => x.SubstrateId);
                });

            migrationBuilder.InsertData(
                table: "GrowRooms",
                columns: new[] { "GrowRoomId", "CreatedAt", "DeletedAt", "Name", "NumberOfTrolleys", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("6c61beff-21d2-4048-81da-dd726c3257d9"), new DateTime(2023, 5, 23, 15, 52, 21, 425, DateTimeKind.Local).AddTicks(1144), null, "1", 16, new DateTime(2023, 5, 23, 15, 52, 21, 426, DateTimeKind.Local).AddTicks(8153) },
                    { new Guid("77e75f7f-2da2-48dc-b260-f7b9a8e625d5"), new DateTime(2023, 5, 23, 15, 52, 21, 426, DateTimeKind.Local).AddTicks(8487), null, "2", 16, new DateTime(2023, 5, 23, 15, 52, 21, 426, DateTimeKind.Local).AddTicks(8497) },
                    { new Guid("33f0de00-3dec-4e20-abdc-843e37decadc"), new DateTime(2023, 5, 23, 15, 52, 21, 426, DateTimeKind.Local).AddTicks(8501), null, "3", 16, new DateTime(2023, 5, 23, 15, 52, 21, 426, DateTimeKind.Local).AddTicks(8503) },
                    { new Guid("e91b5480-563c-490c-babc-51de101e9be8"), new DateTime(2023, 5, 23, 15, 52, 21, 426, DateTimeKind.Local).AddTicks(8506), null, "4", 16, new DateTime(2023, 5, 23, 15, 52, 21, 426, DateTimeKind.Local).AddTicks(8508) },
                    { new Guid("f9359442-730d-40c9-9ec5-27a46686992a"), new DateTime(2023, 5, 23, 15, 52, 21, 426, DateTimeKind.Local).AddTicks(8511), null, "5", 16, new DateTime(2023, 5, 23, 15, 52, 21, 426, DateTimeKind.Local).AddTicks(8513) },
                    { new Guid("53047329-2afe-4d78-a3e1-acbdaf1fbb9a"), new DateTime(2023, 5, 23, 15, 52, 21, 426, DateTimeKind.Local).AddTicks(8515), null, "6", 16, new DateTime(2023, 5, 23, 15, 52, 21, 426, DateTimeKind.Local).AddTicks(8517) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batches");

            migrationBuilder.DropTable(
                name: "GrowRooms");

            migrationBuilder.DropTable(
                name: "StockItems");

            migrationBuilder.DropTable(
                name: "Substrates");
        }
    }
}
