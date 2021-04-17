using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movibio.BusinessLayer.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieProducers");

            migrationBuilder.DropTable(
                name: "ProducerCorporate");

            migrationBuilder.DropTable(
                name: "ProducerIndividual");

            migrationBuilder.DropTable(
                name: "Producers");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PicturePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieProducers",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ProducerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieProducers", x => new { x.MovieId, x.ProducerId });
                    table.ForeignKey(
                        name: "FK_MovieProducers_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieProducers_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProducerCorporate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ProducerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProducerCorporate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProducerCorporate_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProducerIndividual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ProducerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProducerIndividual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProducerIndividual_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_MovieProducers_ProducerId",
                table: "MovieProducers",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProducerCorporate_ProducerId",
                table: "ProducerCorporate",
                column: "ProducerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProducerIndividual_ProducerId",
                table: "ProducerIndividual",
                column: "ProducerId",
                unique: true);
        }
    }
}
