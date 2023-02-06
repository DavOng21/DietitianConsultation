using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DietitianConsultation.Server.Migrations
{
    public partial class dbfoodid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NutritionLists_Foods_FoodId",
                table: "NutritionLists");

            migrationBuilder.AlterColumn<int>(
                name: "FoodId",
                table: "NutritionLists",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "670d046a-f865-4f1c-8a3f-5a783be14e67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "4863dd92-7eda-4110-bdfa-5a4aec2ff67d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfe1caf8-2841-469e-abc6-82051ba7ad74", "AQAAAAEAACcQAAAAEPupyyGIMqRDNlwADckIGsgoYVZecMgvHi4xBbkiiKR/yOOeY1OGdLZNnUfuJ/I6/A==", "70585f51-9dde-432a-9695-67b0f6bc5426" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 33, 30, 963, DateTimeKind.Local).AddTicks(3852), new DateTime(2023, 2, 3, 18, 33, 30, 965, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 33, 30, 966, DateTimeKind.Local).AddTicks(2068), new DateTime(2023, 2, 3, 18, 33, 30, 966, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 33, 30, 969, DateTimeKind.Local).AddTicks(5270), new DateTime(2023, 2, 3, 18, 33, 30, 969, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 33, 30, 969, DateTimeKind.Local).AddTicks(5299), new DateTime(2023, 2, 3, 18, 33, 30, 969, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionLists_Foods_FoodId",
                table: "NutritionLists",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NutritionLists_Foods_FoodId",
                table: "NutritionLists");

            migrationBuilder.AlterColumn<int>(
                name: "FoodId",
                table: "NutritionLists",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionLists_Foods_FoodId",
                table: "NutritionLists",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
