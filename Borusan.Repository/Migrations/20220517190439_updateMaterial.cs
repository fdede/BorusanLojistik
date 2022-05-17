using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Borusan.Repository.Migrations
{
    public partial class updateMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Materials",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "WeightUnits",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "WeightUnits",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8306));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Materials");

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
        }
    }
}
