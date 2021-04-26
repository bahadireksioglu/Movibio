using Microsoft.EntityFrameworkCore.Migrations;

namespace Movibio.BusinessLayer.Migrations
{
    public partial class InitialCreate10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "bdb9f2f9-1101-4111-b54e-b2e7a735a071");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3389f983-3b36-48f3-9cd0-8844e48c5f4a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 3, "4f90e820-0030-4e52-ab54-5e45b610ff0a", "Standart", "STANDART" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2adbb34a-b3dd-485a-9dd0-56b61ee6ff52", "AQAAAAEAACcQAAAAEC+h2Zc/Jpshj0dIsjjanA3Ii6LvVQ/VTZWc5r8ZeiQ6PUMY5Q3/1yrLkZWGXTCpqw==", "1e936045-5d2c-44e1-8111-9b63d1703f03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc505a55-3cbb-47c1-9961-5e1f77d216d4", "AQAAAAEAACcQAAAAEDvRTSk/P7eDeo1JVADIim8OjI6BxkxGPBmoXLdVSLQ0ci6Bpd1cp2qhur/X7xmNPg==", "3728dca8-aa26-46d7-a860-81d82c2ded54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "191dc59c-b7c7-4050-8861-3e50e6608ea4", "7eb4affb-261d-406a-9d26-9ddaf030606c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 3, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8735cbbc-9e98-45aa-ada6-8e4a38ba1149");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4a226af4-a3a3-4c77-b987-0edf56e1f03c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cac04006-4fb6-4e87-9d63-622c693b9a9b", "AQAAAAEAACcQAAAAEHLxXWp6WmmF9tQdNVjfHXXsE8lhRIrDzH1eR4YsPQwqA05DavMy0RmQ0KTgTBzLRA==", "21eb0370-166a-4f79-82cc-95cab3aa1aca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d74222b-2e26-45d0-92d2-aefa77e21f12", "AQAAAAEAACcQAAAAECLWkq0fIkMnblRsngtq2s47Eb4nqep4Er+MNLoK9YFgdJBIOZ5MB3Sq3283X/g+JQ==", "290150b0-f45b-4d81-8ff8-59513d065757" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "adc1a1d7-8ce1-49db-a564-1bcd71cc70a2", "c3ee7c12-9605-4d89-ac4c-9e012e7b330b" });
        }
    }
}
