using Microsoft.EntityFrameworkCore.Migrations;

namespace Movibio.BusinessLayer.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Casts_AspNetUsers_CreatedUserId",
                table: "Casts");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CreatedUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Directors_AspNetUsers_CreatedUserId",
                table: "Directors");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_AspNetUsers_CreatedUserId",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_AspNetUsers_CreatedUserId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_AspNetUsers_CreatedUserId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Producers_AspNetUsers_CreatedUserId",
                table: "Producers");

            migrationBuilder.DropForeignKey(
                name: "FK_Scenarists_AspNetUsers_CreatedUserId",
                table: "Scenarists");

            migrationBuilder.DropIndex(
                name: "IX_Scenarists_CreatedUserId",
                table: "Scenarists");

            migrationBuilder.DropIndex(
                name: "IX_Producers_CreatedUserId",
                table: "Producers");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CreatedUserId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Languages_CreatedUserId",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Genres_CreatedUserId",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Directors_CreatedUserId",
                table: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CreatedUserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Casts_CreatedUserId",
                table: "Casts");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Scenarists");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Casts");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserName",
                table: "Scenarists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUserName",
                table: "Scenarists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserName",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUserName",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserName",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUserName",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserName",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUserName",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserName",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUserName",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserName",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUserName",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUserName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserName",
                table: "Casts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUserName",
                table: "Casts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7e688f03-43b6-4f44-a6b3-f02e7feebca0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4bbe53da-9d93-45aa-9943-7a4a1b0c4101");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf7b6fc0-096b-4485-840c-a033f3d08f92", "AQAAAAEAACcQAAAAELWsrKpwrcoxXEEoTDnVPtAADcY2SFm33U3Jj5/ODo/vywME0Mdw7ZqLEhkfA/pRmg==", "cc853d9d-7047-4461-bd04-bb23f660a103" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88f5a0ee-e21a-4dfa-af99-5ee47140f264", "AQAAAAEAACcQAAAAEMvgwVnGqn5sNdjEiTQVfCXGbjOBbeve9l3HvAQzQaZt/PGDQs2B2fwAdHvdLVtbeA==", "8bfc9985-7eb0-4d9a-a323-d239bbb02845" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserName",
                table: "Scenarists");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserName",
                table: "Scenarists");

            migrationBuilder.DropColumn(
                name: "CreatedByUserName",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserName",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "CreatedByUserName",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserName",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CreatedByUserName",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserName",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "CreatedByUserName",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserName",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "CreatedByUserName",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserName",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "CreatedByUserName",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserName",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CreatedByUserName",
                table: "Casts");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserName",
                table: "Casts");

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Scenarists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Producers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Languages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Genres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Directors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Casts",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Scenarists_CreatedUserId",
                table: "Scenarists",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Producers_CreatedUserId",
                table: "Producers",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CreatedUserId",
                table: "Movies",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_CreatedUserId",
                table: "Languages",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_CreatedUserId",
                table: "Genres",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_CreatedUserId",
                table: "Directors",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CreatedUserId",
                table: "Comments",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Casts_CreatedUserId",
                table: "Casts",
                column: "CreatedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Casts_AspNetUsers_CreatedUserId",
                table: "Casts",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_CreatedUserId",
                table: "Comments",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_AspNetUsers_CreatedUserId",
                table: "Directors",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_AspNetUsers_CreatedUserId",
                table: "Genres",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_AspNetUsers_CreatedUserId",
                table: "Languages",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_AspNetUsers_CreatedUserId",
                table: "Movies",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Producers_AspNetUsers_CreatedUserId",
                table: "Producers",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Scenarists_AspNetUsers_CreatedUserId",
                table: "Scenarists",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
