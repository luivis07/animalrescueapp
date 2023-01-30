using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace animalrescue.mainmodule.dal.Migrations.SqlServerMigrations
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Agreement = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationAgreement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationInterest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interest = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationInterest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationPurpose",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Purpose = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationPurpose", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfPet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerApplication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalRescueAccountId = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    City = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    HaveDogTraining = table.Column<bool>(type: "bit", nullable: true),
                    DogTrainingDetails = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    HaveBottleFeeding = table.Column<bool>(type: "bit", nullable: true),
                    BottleFeedingDetails = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    HaveGrantWriting = table.Column<bool>(type: "bit", nullable: true),
                    GrantWritingDetails = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OwnDog = table.Column<bool>(type: "bit", nullable: true),
                    OwnCat = table.Column<bool>(type: "bit", nullable: true),
                    ConvictedFelonyOfAnimals = table.Column<bool>(type: "bit", nullable: true),
                    ConvictedFelonyOfAnimalsDetails = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
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
                    VolunteerApplicationId = table.Column<int>(type: "int", nullable: false),
                    ApplicationAgreementId = table.Column<int>(type: "int", nullable: false)
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
                    VolunteerApplicationId = table.Column<int>(type: "int", nullable: false),
                    ApplicationInterestId = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolunteerApplicationId = table.Column<int>(type: "int", nullable: false),
                    PetTypeId = table.Column<int>(type: "int", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true)
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
                    VolunteerApplicationId = table.Column<int>(type: "int", nullable: false),
                    ApplicationPurposeId = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalRescueAccountId = table.Column<int>(type: "int", nullable: false)
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
