using Microsoft.EntityFrameworkCore.Migrations;

namespace Movibio.BusinessLayer.Migrations
{
    public partial class InitialCreate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 3, 0, "adc1a1d7-8ce1-49db-a564-1bcd71cc70a2", "normal@gmail.com", true, false, null, "NORMAL@GMAIL.COM", "NORMAL", null, "+904444444444", true, "c3ee7c12-9605-4d89-ac4c-9e012e7b330b", false, "normal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4e830041-1fe6-4965-8adf-0baff8b2d636");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "38cede34-3030-478e-b7fa-19a14bfd3ba6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0365132e-867d-43f2-aaf5-4a19c8375e7c", "AQAAAAEAACcQAAAAEOshTTy0oXPhw979bMjry0w0dKyJglYdKSXC2h1FtKthjKaTfJYpU3JimtwXjD40pg==", "804c1eb3-bc7f-4454-a88c-7eb57039dd63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fa7bee1-43a8-4d4c-bb8b-48763d32bf18", "AQAAAAEAACcQAAAAEJ01rM2jTmEsKGd9mjCPN/BR5LJkZc10WlHt6LxPAOFBvTKWfoxkA8cc0cSmwyWg0g==", "7b5f1c8b-5cce-4eb2-b57b-dc2e8e77d112" });
        }
    }
}
