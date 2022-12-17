using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DietitianConsultation.Server.Data.Migrations
{
    public partial class AddFoodSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "15da1ba7-0c8d-4e18-bcbd-ed6ff2e91c9c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "da863fa5-4382-4090-a29e-3e26467649c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bae55a2-48db-4703-af5a-a3a71169d762", "AQAAAAEAACcQAAAAEM+R1O5zzptaNPMLYXmipCpDnCs+gWVdI/cPGMioO2XKLBGpHRC66IxScdajVg8LHw==", "1debf5db-a1e3-4a2e-a596-290c3707d851" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 17, 15, 36, 16, 901, DateTimeKind.Local).AddTicks(5605), new DateTime(2022, 12, 17, 15, 36, 16, 903, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 17, 15, 36, 16, 903, DateTimeKind.Local).AddTicks(3616), new DateTime(2022, 12, 17, 15, 36, 16, 903, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 17, 15, 36, 16, 904, DateTimeKind.Local).AddTicks(9214), new DateTime(2022, 12, 17, 15, 36, 16, 904, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 17, 15, 36, 16, 904, DateTimeKind.Local).AddTicks(9244), new DateTime(2022, 12, 17, 15, 36, 16, 904, DateTimeKind.Local).AddTicks(9245) });
        }
    }
}
