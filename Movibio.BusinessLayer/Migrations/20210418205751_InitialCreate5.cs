using Microsoft.EntityFrameworkCore.Migrations;

namespace Movibio.BusinessLayer.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Movies",
                type: "NVARCHAR(MAX)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Movies",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(MAX)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "506921de-873c-4528-b2e9-84a5b5c71ae2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b547e7cd-c596-4cdf-8e9d-38bc91a7e7e0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c362f4b-a09d-4e4b-add3-39d1e4ed89b3", "AQAAAAEAACcQAAAAEFFtarYRrqC77fFRQDCUmVkz27fJNz9ZCEqU8AkWhUoay/Fbbxxp2381WPt7PegVTA==", "809a618b-f7f1-4f50-bec5-8185dc265978" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54330e96-dc4d-4de6-b1bd-de4a50e851e2", "AQAAAAEAACcQAAAAEOiUSBZSc1flxi38S2gnxKzUJiEkeKKQrgLwob5MVuWyJ9DfXT6Ff83VMxTwZ3BeTw==", "a46df176-5b84-4b00-b255-91d37946e943" });
        }
    }
}
