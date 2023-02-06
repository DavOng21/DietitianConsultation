using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DietitianConsultation.Server.Migrations
{
    public partial class newdb_valid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Patients",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Patients",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MedicalHistory",
                table: "PatientInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityRate",
                table: "PatientInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "391e483d-bc76-4648-9b30-cfcc44fb53d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "f0da18c1-56b4-4993-857f-1fe0c91d5d0a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84fa06d8-90ad-4b04-af38-4d6d77495525", "AQAAAAEAACcQAAAAENAh43bRqu/Xfb7NnjWkAEbid3AwPJz09GBFDsN8DKMhWkMxNUpJfwgViVhdJotMHA==", "5d73170f-49be-4d89-9375-93c645a64c8d" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 17, 39, 31, 730, DateTimeKind.Local).AddTicks(749), new DateTime(2023, 1, 31, 17, 39, 31, 732, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 17, 39, 31, 732, DateTimeKind.Local).AddTicks(9826), new DateTime(2023, 1, 31, 17, 39, 31, 732, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 17, 39, 31, 737, DateTimeKind.Local).AddTicks(3232), new DateTime(2023, 1, 31, 17, 39, 31, 737, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 17, 39, 31, 737, DateTimeKind.Local).AddTicks(3273), new DateTime(2023, 1, 31, 17, 39, 31, 737, DateTimeKind.Local).AddTicks(3275) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Patients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MedicalHistory",
                table: "PatientInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ActivityRate",
                table: "PatientInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "7c8f9948-6870-4d7c-9f5f-a2d76c60d055");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "15b442e4-82d0-41c4-b4e0-5a470ae90e04");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea871432-1bfa-479c-8125-cf5cc2c3cc48", "AQAAAAEAACcQAAAAEIx7o4KXRSWiCdKhksVF6iZv3o6JzqB7c2Muh0bLJt+Fc4kLW+oCFUITsdPjBjVhLw==", "a86fca18-b909-43e3-8239-53fdd6cdd026" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 16, 41, 22, 317, DateTimeKind.Local).AddTicks(9403), new DateTime(2023, 1, 30, 16, 41, 22, 319, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 16, 41, 22, 320, DateTimeKind.Local).AddTicks(967), new DateTime(2023, 1, 30, 16, 41, 22, 320, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 16, 41, 22, 322, DateTimeKind.Local).AddTicks(4688), new DateTime(2023, 1, 30, 16, 41, 22, 322, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 30, 16, 41, 22, 322, DateTimeKind.Local).AddTicks(4724), new DateTime(2023, 1, 30, 16, 41, 22, 322, DateTimeKind.Local).AddTicks(4726) });
        }
    }
}
