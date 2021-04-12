using Microsoft.EntityFrameworkCore.Migrations;

namespace Movibio.BusinessLayer.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PosterPath",
                table: "Movies",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1fe0a1e6-6711-4727-9a33-61e08dd7a7ac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a56c4f04-45a5-4955-925c-865533d8df24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41bdcf1b-3ddd-4a1e-a0f2-3c0b604cbdbd", "AQAAAAEAACcQAAAAEBLY5O3W4jzAtIX+8ai9nIhMJFMmpu3DSE5ssTmwRvAlGRjIK2eGU1EAAC0mDSSWCw==", "b784280e-762a-46d6-b00b-2492b25190cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00a7f26f-559f-4684-862c-23daaa5efdb8", "AQAAAAEAACcQAAAAEPP396QNuhwDTnK/Pj92jN3u4gm01aLYwoCJFwSAfTBNUZciyihmx62HaB0qnJn+Tw==", "8fb3f85f-6e51-4e0e-9c0e-d32158414397" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PosterPath",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "bbaa033e-de8a-4083-9876-d476c17c70e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "12dbea77-f20d-4b8c-b6e7-b80a20fac374");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3b9bc4d-ac74-4e93-9962-710a283ce238", "AQAAAAEAACcQAAAAEKKoAsSxXRdOapOs1XoRNgZq35Evf9X1joy10LIOZyNB3JbUge4I+2c0yZK+t7EH9w==", "7fd81a89-b8a4-4f17-98fb-f81c1bd061af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42e21f49-46fe-475a-bfd6-d8109b6a9ce9", "AQAAAAEAACcQAAAAEFb6qqr6PlXXP6E2L7RYQh2osaAqz2omEOJeGh77QObRLI+vCItBTjOwHAu/XX+huQ==", "33d97c76-4695-493e-a6ca-eb8f600a52ca" });
        }
    }
}
