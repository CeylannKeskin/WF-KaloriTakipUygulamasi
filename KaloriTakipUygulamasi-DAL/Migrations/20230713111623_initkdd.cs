using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipUygulamasi_DAL.Migrations
{
    public partial class initkdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Category Picture",
                table: "Food Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: 1,
                columns: new[] { "Birth Date", "Created Time", "Updated Time" },
                values: new object[] { new DateTime(2023, 7, 13, 14, 16, 17, 638, DateTimeKind.Local).AddTicks(1392), new DateTime(2023, 7, 13, 14, 16, 17, 638, DateTimeKind.Local).AddTicks(1394), new DateTime(2023, 7, 13, 14, 16, 17, 638, DateTimeKind.Local).AddTicks(1396) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Category Picture",
                table: "Food Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountID",
                keyValue: 1,
                columns: new[] { "Birth Date", "Created Time", "Updated Time" },
                values: new object[] { new DateTime(2023, 7, 13, 10, 16, 46, 829, DateTimeKind.Local).AddTicks(8626), new DateTime(2023, 7, 13, 10, 16, 46, 829, DateTimeKind.Local).AddTicks(8629), new DateTime(2023, 7, 13, 10, 16, 46, 829, DateTimeKind.Local).AddTicks(8631) });
        }
    }
}
