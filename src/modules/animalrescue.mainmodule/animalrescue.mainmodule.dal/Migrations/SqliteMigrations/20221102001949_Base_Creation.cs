using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace animalrescue.mainmodule.dal.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class BaseCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimalRescueAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    EmailAddress = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Address1 = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Address2 = table.Column<string>(type: "TEXT", maxLength: 60, nullable: true),
                    City = table.Column<string>(type: "TEXT", maxLength: 60, nullable: true),
                    State = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Country = table.Column<string>(type: "TEXT", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalRescueAccount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalendarType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnimalRescueAccountAdoptionApplication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimalRescueAccountId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalRescueAccountAdoptionApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalRescueAccountAdoptionApplication_AnimalRescueAccount_AnimalRescueAccountId",
                        column: x => x.AnimalRescueAccountId,
                        principalTable: "AnimalRescueAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalRescueAccountFosterApplication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimalRescueAccountId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalRescueAccountFosterApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalRescueAccountFosterApplication_AnimalRescueAccount_AnimalRescueAccountId",
                        column: x => x.AnimalRescueAccountId,
                        principalTable: "AnimalRescueAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalRescueAccountVolunteerApplication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimalRescueAccountId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalRescueAccountVolunteerApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalRescueAccountVolunteerApplication_AnimalRescueAccount_AnimalRescueAccountId",
                        column: x => x.AnimalRescueAccountId,
                        principalTable: "AnimalRescueAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalRescueAccountLocation",
                columns: table => new
                {
                    AnimalRescueAccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    LocationId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalRescueAccountLocation", x => new { x.AnimalRescueAccountId, x.LocationId });
                    table.ForeignKey(
                        name: "FK_AnimalRescueAccountLocation_AnimalRescueAccount_AnimalRescueAccountId",
                        column: x => x.AnimalRescueAccountId,
                        principalTable: "AnimalRescueAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalRescueAccountLocation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calendar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CalendarTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    LocationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendar_CalendarType_CalendarTypeId",
                        column: x => x.CalendarTypeId,
                        principalTable: "CalendarType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calendar_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalRescueAccountRole",
                columns: table => new
                {
                    AnimalRescueAccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalRescueAccountRole", x => new { x.AnimalRescueAccountId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AnimalRescueAccountRole_AnimalRescueAccount_AnimalRescueAccountId",
                        column: x => x.AnimalRescueAccountId,
                        principalTable: "AnimalRescueAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalRescueAccountRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CalendarId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_Calendar_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalRescueAccountAdoptionApplication_AnimalRescueAccountId",
                table: "AnimalRescueAccountAdoptionApplication",
                column: "AnimalRescueAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalRescueAccountFosterApplication_AnimalRescueAccountId",
                table: "AnimalRescueAccountFosterApplication",
                column: "AnimalRescueAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AnimalRescueAccountLocation_LocationId",
                table: "AnimalRescueAccountLocation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalRescueAccountRole_RoleId",
                table: "AnimalRescueAccountRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalRescueAccountVolunteerApplication_AnimalRescueAccountId",
                table: "AnimalRescueAccountVolunteerApplication",
                column: "AnimalRescueAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calendar_CalendarTypeId",
                table: "Calendar",
                column: "CalendarTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Calendar_LocationId",
                table: "Calendar",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_CalendarId",
                table: "Event",
                column: "CalendarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalRescueAccountAdoptionApplication");

            migrationBuilder.DropTable(
                name: "AnimalRescueAccountFosterApplication");

            migrationBuilder.DropTable(
                name: "AnimalRescueAccountLocation");

            migrationBuilder.DropTable(
                name: "AnimalRescueAccountRole");

            migrationBuilder.DropTable(
                name: "AnimalRescueAccountVolunteerApplication");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "AnimalRescueAccount");

            migrationBuilder.DropTable(
                name: "Calendar");

            migrationBuilder.DropTable(
                name: "CalendarType");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
