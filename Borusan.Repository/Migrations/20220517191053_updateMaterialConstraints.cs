using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Borusan.Repository.Migrations
{
    public partial class updateMaterialConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Materials",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "AmountTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "MLZ-1234", new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "MLZ-1235", new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "MLZ-1236", new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "WeightUnits",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "WeightUnits",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 17, 22, 10, 53, 470, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.CreateIndex(
                name: "IX_Materials_Code",
                table: "Materials",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Materials_Code",
                table: "Materials");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Materials",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { null, new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { null, new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { null, new DateTime(2022, 5, 17, 22, 4, 39, 552, DateTimeKind.Local).AddTicks(8077) });

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
    }
}
