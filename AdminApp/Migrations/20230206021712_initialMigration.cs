using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdminApp.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNr = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cost = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    OfficeId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<double>(type: "REAL", nullable: false),
                    Supply = table.Column<int>(type: "INTEGER", nullable: false),
                    YearSalesTotal = table.Column<double>(type: "REAL", nullable: false),
                    YearTotalSoldUnits = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TransactionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDateTime", "Name", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(299), "Trousers", new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(304) },
                    { 2, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(309), "T-Shirts", new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(311) },
                    { 3, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(314), "Sweaters", new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(316) },
                    { 4, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(319), "Jackets", new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(321) },
                    { 5, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(324), "Accesories", new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(326) }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "City", "Country", "CreateDateTime", "Email", "LastName", "Name", "PhoneNr", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, "Long str. 18-5", "Berlin", "Germany", new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(406), "a.jhones@gmail.com", "Jhones", "Anthony", 45755362, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(409) },
                    { 2, "Long str. 18-5", "London", "UK", new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(416), "j.smiths@gmail.com", "Smith", "Jack", 45755362, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(419) },
                    { 3, "Long str. 18-5", "New York", "US", new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(422), "james.camerons@gmail.com", "Cameron", "James", 45755362, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(425) },
                    { 4, "Long str. 18-5", "Madrid", "Spain", new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(429), "carol.antuan@gmail.com", "Antuanete", "Carolina", 45755362, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(432) },
                    { 5, "Long str. 18-5", "Rome", "Italy", new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(435), "jess.benton@gmail.com", "Benton", "Jesicca", 45755362, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(438) }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Address", "City", "Country", "CreateDateTime", "UpdateDateTime" },
                values: new object[] { 1, "Vilnius str.", "Vilnius", "Lithuania", new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(490), new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateDateTime", "Description", "Name", "Price", "Rating", "Supply", "TransactionId", "UpdateDateTime", "YearSalesTotal", "YearTotalSoldUnits" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(85), "You can put it on your hand", "Bracelet", 14.99, 4.2000000000000002, 4478, null, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(121), 21675.540000000001, 1446 },
                    { 2, 2, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(130), "Perfectly balanced", "White T-Shirt", 21.989999999999998, 3.6000000000000001, 14889, null, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(131), 30324.330000000002, 1335 },
                    { 3, 1, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(134), "Good even for riding", "Denim Jeans", 35.0, 4.9000000000000004, 5874, null, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(136), 33320.0, 952 },
                    { 4, 3, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(139), "For cold winters", "Orange Sweater", 25.989999999999998, 3.7999999999999998, 1336, null, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(140), 20662.049999999999, 795 },
                    { 5, 4, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(142), "Casual wear", "Jeans jacket", 59.990000000000002, 5.4000000000000004, 4478, null, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(144), 21675.540000000001, 1446 }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "CreateDateTime", "Email", "LastName", "Name", "OfficeId", "Role", "UpdateDateTime" },
                values: new object[] { 1, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(462), "admin.root@adminapp.com", "Root", "Admin", 1, "root", new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "ClientId", "Cost", "CreateDateTime", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, 1, 255, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(354), new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(357) },
                    { 2, 2, 345, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(365), new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(367) },
                    { 3, 1, 399, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(370), new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(373) },
                    { 4, 4, 265, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(375), new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(378) },
                    { 5, 3, 146, new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(380), new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(383) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TransactionId",
                table: "Products",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_OfficeId",
                table: "Staff",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ClientId",
                table: "Transactions",
                column: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
