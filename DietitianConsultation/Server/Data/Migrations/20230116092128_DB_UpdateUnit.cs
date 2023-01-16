using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DietitianConsultation.Server.Data.Migrations
{
    public partial class DB_UpdateUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "7d2aae8f-e5f4-4f4f-8e39-7e4f727ba4d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "e8cf41c4-9126-466b-930e-6ab36fb57443");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d74caee-91d4-4d69-9260-68a9755e6c5c", "AQAAAAEAACcQAAAAEOfhYsYvrbDh+F37dFUVJX1K472qEbOexzgQ/8OJS1p/tSfSU8pArVye4ovDBJrR+A==", "53555f66-cf9a-4a9d-a806-36fb7add7827" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 16, 17, 21, 27, 511, DateTimeKind.Local).AddTicks(3113), new DateTime(2023, 1, 16, 17, 21, 27, 512, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 16, 17, 21, 27, 512, DateTimeKind.Local).AddTicks(5165), new DateTime(2023, 1, 16, 17, 21, 27, 512, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 16, 17, 21, 27, 513, DateTimeKind.Local).AddTicks(7536), new DateTime(2023, 1, 16, 17, 21, 27, 513, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 16, 17, 21, 27, 513, DateTimeKind.Local).AddTicks(7549), new DateTime(2023, 1, 16, 17, 21, 27, 513, DateTimeKind.Local).AddTicks(7550) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "4a261de8-dde5-4544-b5f1-f564f8ca05e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "f75e0fb9-010e-4dad-993e-ac4a581daeae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d15f55fe-17dc-4428-a485-497f5f510ddd", "AQAAAAEAACcQAAAAEEJfqoI80S+3O2TM+TqW2tB1ZoHKXZZ7inMdyID/BYRnO0F+GuuX2A1yf0oZgQWisw==", "b4a44872-b2a8-441b-ad5d-3e466556de98" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 17, 15, 39, 0, 598, DateTimeKind.Local).AddTicks(3015), new DateTime(2022, 12, 17, 15, 39, 0, 599, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 17, 15, 39, 0, 599, DateTimeKind.Local).AddTicks(4645), new DateTime(2022, 12, 17, 15, 39, 0, 599, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 17, 15, 39, 0, 600, DateTimeKind.Local).AddTicks(7611), new DateTime(2022, 12, 17, 15, 39, 0, 600, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 17, 15, 39, 0, 600, DateTimeKind.Local).AddTicks(7624), new DateTime(2022, 12, 17, 15, 39, 0, 600, DateTimeKind.Local).AddTicks(7625) });
        }
    }
}
