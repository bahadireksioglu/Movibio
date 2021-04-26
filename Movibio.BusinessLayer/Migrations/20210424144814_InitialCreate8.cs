using Microsoft.EntityFrameworkCore.Migrations;

namespace Movibio.BusinessLayer.Migrations
{
    public partial class InitialCreate8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "AverageScore",
                table: "Movies",
                type: "DECIMAL(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(3,2)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "AverageScore",
                table: "Movies",
                type: "DECIMAL(3,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(5,2)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4d01d182-a6b3-4775-84f8-f5b74c243a59");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "14141a59-77f0-4f31-adef-7f2cc42b9ac4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4347e29-b70e-4eed-b401-894eca9871ff", "AQAAAAEAACcQAAAAEN+cjRmPDWRJwjMcA6dUirjYr8tp/g4WEijLxfEygU6+H0uJ2epvibyfxTEqCK2pWw==", "aef9d89b-8d86-4046-b03a-bbb0037545d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d499819b-efbc-4ea6-804d-85a5716c7a40", "AQAAAAEAACcQAAAAEOUi6BRC0JA9xgxrLlZGCwywBc3Y00AahhAwbfoUVVTfLyHFyB7q1iVqms7c0dYe3Q==", "8624795b-8406-479b-b603-f10a488ee5ba" });
        }
    }
}
