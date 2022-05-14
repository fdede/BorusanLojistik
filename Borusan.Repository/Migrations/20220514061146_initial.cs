using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Borusan.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmountTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmountTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeightUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerOrderNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FromAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    AmountTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WeightUnitId = table.Column<long>(type: "bigint", nullable: false),
                    MaterialId = table.Column<long>(type: "bigint", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderStatusId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AmountTypes_AmountTypeId",
                        column: x => x.AmountTypeId,
                        principalTable: "AmountTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatuses_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_WeightUnits_WeightUnitId",
                        column: x => x.WeightUnitId,
                        principalTable: "WeightUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AmountTypes",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2148), "Adet", null },
                    { 2L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2161), "Koli", null },
                    { 3L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2162), "Paket", null },
                    { 4L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2162), "palet", null }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2396), "Monitör", null },
                    { 2L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2397), "Klavye", null },
                    { 3L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2398), "Mouse", null }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2519), "Sipariş Alındı", null },
                    { 2L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2520), "Yola Çıktı", null },
                    { 3L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2521), "Dağıtım Merkezinde", null },
                    { 4L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2522), "Dağıtıma Çıktı", null },
                    { 5L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2523), "Teslim Edildi", null },
                    { 6L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2524), "Teslim Edilemedi", null }
                });

            migrationBuilder.InsertData(
                table: "WeightUnits",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2632), "Kg", null },
                    { 2L, new DateTime(2022, 5, 14, 9, 11, 46, 688, DateTimeKind.Local).AddTicks(2633), "Ton", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AmountTypeId",
                table: "Orders",
                column: "AmountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MaterialId",
                table: "Orders",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WeightUnitId",
                table: "Orders",
                column: "WeightUnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AmountTypes");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "WeightUnits");
        }
    }
}
