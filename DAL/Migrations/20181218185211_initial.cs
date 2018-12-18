using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Msisdns",
                columns: table => new
                {
                    MsisdnId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Msisdns", x => x.MsisdnId);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    SmsTransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MsisdnId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.SmsTransactionId);
                    table.ForeignKey(
                        name: "FK_Transactions_Msisdns_MsisdnId",
                        column: x => x.MsisdnId,
                        principalTable: "Msisdns",
                        principalColumn: "MsisdnId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Msisdns",
                columns: new[] { "MsisdnId", "Number" },
                values: new object[,]
                {
                    { -1, 37062300001L },
                    { -2, 37062300002L },
                    { -3, 37062300003L },
                    { -4, 37062300004L },
                    { -5, 37062300005L },
                    { -6, 37062300006L },
                    { -7, 37062300007L },
                    { -8, 37062300008L },
                    { -9, 37062300009L },
                    { -10, 37062300010L }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "TypeId", "Name" },
                values: new object[,]
                {
                    { 1, "sms" },
                    { 2, "call" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "SmsTransactionId", "Created", "Duration", "MsisdnId", "TypeId" },
                values: new object[,]
                {
                    { -1, new DateTime(2018, 12, 18, 20, 52, 10, 607, DateTimeKind.Local).AddTicks(1860), 0, -1, 1 },
                    { -18, new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8647), 47, -8, 2 },
                    { -17, new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8588), 68, -7, 2 },
                    { -16, new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8585), 75, -6, 2 },
                    { -15, new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8581), 34, -5, 2 },
                    { -14, new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8576), 7, -4, 2 },
                    { -13, new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8572), 20, -3, 2 },
                    { -12, new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8567), 34, -2, 2 },
                    { -11, new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8562), 10, -1, 2 },
                    { -10, new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8556), 0, -10, 1 },
                    { -9, new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8548), 0, -9, 1 },
                    { -8, new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8543), 0, -8, 1 },
                    { -7, new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8539), 0, -7, 1 },
                    { -6, new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8532), 0, -6, 1 },
                    { -5, new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8518), 0, -5, 1 },
                    { -4, new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8514), 0, -4, 1 },
                    { -3, new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8508), 0, -3, 1 },
                    { -2, new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8487), 0, -2, 1 },
                    { -19, new DateTime(2018, 12, 17, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8652), 41, -9, 2 },
                    { -20, new DateTime(2018, 12, 18, 20, 52, 10, 609, DateTimeKind.Local).AddTicks(8656), 40, -10, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Msisdns_Number",
                table: "Msisdns",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_MsisdnId",
                table: "Transactions",
                column: "MsisdnId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TypeId",
                table: "Transactions",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Msisdns");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
