using Microsoft.EntityFrameworkCore.Migrations;

namespace Movibio.BusinessLayer.Migrations
{
    public partial class InitialCreate11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "dbcc2d3b-903e-4aad-8763-beaf02047319");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "bb22a6b1-ad8b-4ab5-bf40-6ba1db793646");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "8f9e4847-8445-4c86-81dc-e8d68376653e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8b297eb-4dad-4e31-981c-32fb514a63d8", "AQAAAAEAACcQAAAAEBHm2ex1QE99fYe65nj5jPoOwaDF1PNoWLBlIV6NliYb/+fz7Ox7b3ziaDJJlG2aHA==", "5b9aca4e-25ef-47b0-86ea-643caa8cf81f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f369cfa-c4fa-45e5-9f83-d0f3f7b942d2", "AQAAAAEAACcQAAAAEPcHs7AiIaRqG6xZgNa4TqdRTVa0CVsdCjLKOCTil8A4YfEeLBhY64fgVmiluhkZ2A==", "231344ea-cfdc-4d68-aa16-b01caca6769d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f3f74d4-b432-474b-9aa9-fc1643fd8688", "AQAAAAEAACcQAAAAEHuw4SZ1HGmZB7I5kJg4CGKUkxa/4aGNHJ6emXQE9nrio2kbekrl940oAGFiNWqlDQ==", "bbfe1ac1-0c82-4b55-ac18-fe092756d02a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "4f90e820-0030-4e52-ab54-5e45b610ff0a");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "191dc59c-b7c7-4050-8861-3e50e6608ea4", null, "7eb4affb-261d-406a-9d26-9ddaf030606c" });
        }
    }
}
