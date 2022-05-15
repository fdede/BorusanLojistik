using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Borusan.Repository.Migrations
{
    public partial class CustomerOrderNoUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "WeightUnits",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "WeightUnits",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 15, 12, 52, 26, 434, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerOrderNo",
                table: "Orders",
                column: "CustomerOrderNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerOrderNo",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "WeightUnits",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "WeightUnits",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 14, 23, 50, 32, 34, DateTimeKind.Local).AddTicks(3676));
        }
    }
}
