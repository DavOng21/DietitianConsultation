using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DietitianConsultation.Server.Data.Migrations
{
    public partial class AddPatientSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "15da1ba7-0c8d-4e18-bcbd-ed6ff2e91c9c", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "da863fa5-4382-4090-a29e-3e26467649c1", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "7bae55a2-48db-4703-af5a-a3a71169d762", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEM+R1O5zzptaNPMLYXmipCpDnCs+gWVdI/cPGMioO2XKLBGpHRC66IxScdajVg8LHw==", null, false, "1debf5db-a1e3-4a2e-a596-290c3707d851", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calories", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Name", "ServingSize", "Type", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 220, "System", new DateTime(2022, 12, 17, 15, 36, 16, 901, DateTimeKind.Local).AddTicks(5605), new DateTime(2022, 12, 17, 15, 36, 16, 903, DateTimeKind.Local).AddTicks(1858), "Healthy food that contain vitamin and protein", "Chicken And Broccoli", 1, "Meat and Vegetable", "System" },
                    { 2, 266, "System", new DateTime(2022, 12, 17, 15, 36, 16, 903, DateTimeKind.Local).AddTicks(3616), new DateTime(2022, 12, 17, 15, 36, 16, 903, DateTimeKind.Local).AddTicks(3624), "Fast Food(Unhealthy)", "Pizza", 1, null, "System" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "Contact", "CreatedBy", "DateCreated", "DateOfBirth", "DateUpdated", "Gender", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Tampines Street 21 blk 123", 85567722, "System", new DateTime(2022, 12, 17, 15, 36, 16, 904, DateTimeKind.Local).AddTicks(9214), "22/1/2001", new DateTime(2022, 12, 17, 15, 36, 16, 904, DateTimeKind.Local).AddTicks(9238), "Male", "Joe", "System" },
                    { 2, "Tampines Street 21 blk 123", 84403885, "System", new DateTime(2022, 12, 17, 15, 36, 16, 904, DateTimeKind.Local).AddTicks(9244), "21/7/2006", new DateTime(2022, 12, 17, 15, 36, 16, 904, DateTimeKind.Local).AddTicks(9245), "Male", "Steven", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Patients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
