using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace animalrescue.mainmodule.dal.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class volunteerapplicationcreationrename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalRescueAccountVolunteerApplication");

            migrationBuilder.CreateTable(
                name: "ApplicationAgreement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Agreement = table.Column<string>(type: "TEXT", maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationAgreement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationInterest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Interest = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationInterest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationPurpose",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Purpose = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationPurpose", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeOfPet = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerApplication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimalRescueAccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    Username = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
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
                    Country = table.Column<string>(type: "TEXT", maxLength: 55, nullable: true),
                    HaveDogTraining = table.Column<bool>(type: "INTEGER", nullable: true),
                    DogTrainingDetails = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    HaveBottleFeeding = table.Column<bool>(type: "INTEGER", nullable: true),
                    BottleFeedingDetails = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    HaveGrantWriting = table.Column<bool>(type: "INTEGER", nullable: true),
                    GrantWritingDetails = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    OwnDog = table.Column<bool>(type: "INTEGER", nullable: true),
                    OwnCat = table.Column<bool>(type: "INTEGER", nullable: true),
                    ConvictedFelonyOfAnimals = table.Column<bool>(type: "INTEGER", nullable: true),
                    ConvictedFelonyOfAnimalsDetails = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VolunteerApplication_AnimalRescueAccount_AnimalRescueAccountId",
                        column: x => x.AnimalRescueAccountId,
                        principalTable: "AnimalRescueAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerApplicationAgreement",
                columns: table => new
                {
                    VolunteerApplicationId = table.Column<int>(type: "INTEGER", nullable: false),
                    ApplicationAgreementId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerApplicationAgreement", x => new { x.VolunteerApplicationId, x.ApplicationAgreementId });
                    table.ForeignKey(
                        name: "FK_VolunteerApplicationAgreement_ApplicationAgreement_ApplicationAgreementId",
                        column: x => x.ApplicationAgreementId,
                        principalTable: "ApplicationAgreement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VolunteerApplicationAgreement_VolunteerApplication_VolunteerApplicationId",
                        column: x => x.VolunteerApplicationId,
                        principalTable: "VolunteerApplication",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerApplicationInterest",
                columns: table => new
                {
                    VolunteerApplicationId = table.Column<int>(type: "INTEGER", nullable: false),
                    ApplicationInterestId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerApplicationInterest", x => new { x.VolunteerApplicationId, x.ApplicationInterestId });
                    table.ForeignKey(
                        name: "FK_VolunteerApplicationInterest_ApplicationInterest_ApplicationInterestId",
                        column: x => x.ApplicationInterestId,
                        principalTable: "ApplicationInterest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VolunteerApplicationInterest_VolunteerApplication_VolunteerApplicationId",
                        column: x => x.VolunteerApplicationId,
                        principalTable: "VolunteerApplication",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerApplicationPet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VolunteerApplicationId = table.Column<int>(type: "INTEGER", nullable: false),
                    PetTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Breed = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Sex = table.Column<string>(type: "TEXT", maxLength: 60, nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerApplicationPet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VolunteerApplicationPet_PetType_PetTypeId",
                        column: x => x.PetTypeId,
                        principalTable: "PetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VolunteerApplicationPet_VolunteerApplication_VolunteerApplicationId",
                        column: x => x.VolunteerApplicationId,
                        principalTable: "VolunteerApplication",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerApplicationPurpose",
                columns: table => new
                {
                    VolunteerApplicationId = table.Column<int>(type: "INTEGER", nullable: false),
                    ApplicationPurposeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerApplicationPurpose", x => new { x.VolunteerApplicationId, x.ApplicationPurposeId });
                    table.ForeignKey(
                        name: "FK_VolunteerApplicationPurpose_ApplicationPurpose_ApplicationPurposeId",
                        column: x => x.ApplicationPurposeId,
                        principalTable: "ApplicationPurpose",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VolunteerApplicationPurpose_VolunteerApplication_VolunteerApplicationId",
                        column: x => x.VolunteerApplicationId,
                        principalTable: "VolunteerApplication",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerApplication_AnimalRescueAccountId",
                table: "VolunteerApplication",
                column: "AnimalRescueAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerApplicationAgreement_ApplicationAgreementId",
                table: "VolunteerApplicationAgreement",
                column: "ApplicationAgreementId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerApplicationInterest_ApplicationInterestId",
                table: "VolunteerApplicationInterest",
                column: "ApplicationInterestId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerApplicationPet_PetTypeId",
                table: "VolunteerApplicationPet",
                column: "PetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerApplicationPet_VolunteerApplicationId",
                table: "VolunteerApplicationPet",
                column: "VolunteerApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerApplicationPurpose_ApplicationPurposeId",
                table: "VolunteerApplicationPurpose",
                column: "ApplicationPurposeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VolunteerApplicationAgreement");

            migrationBuilder.DropTable(
                name: "VolunteerApplicationInterest");

            migrationBuilder.DropTable(
                name: "VolunteerApplicationPet");

            migrationBuilder.DropTable(
                name: "VolunteerApplicationPurpose");

            migrationBuilder.DropTable(
                name: "ApplicationAgreement");

            migrationBuilder.DropTable(
                name: "ApplicationInterest");

            migrationBuilder.DropTable(
                name: "PetType");

            migrationBuilder.DropTable(
                name: "ApplicationPurpose");

            migrationBuilder.DropTable(
                name: "VolunteerApplication");

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

            migrationBuilder.CreateIndex(
                name: "IX_AnimalRescueAccountVolunteerApplication_AnimalRescueAccountId",
                table: "AnimalRescueAccountVolunteerApplication",
                column: "AnimalRescueAccountId",
                unique: true);
        }
    }
}
