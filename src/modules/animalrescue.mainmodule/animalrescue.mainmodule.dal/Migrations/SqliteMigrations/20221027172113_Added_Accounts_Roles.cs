using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace animalrescue.mainmodule.dal.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class AddedAccountsRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VolunteerApplications",
                table: "VolunteerApplications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdoptionApplications",
                table: "AdoptionApplications");

            migrationBuilder.RenameTable(
                name: "VolunteerApplications",
                newName: "VolunteerApplication");

            migrationBuilder.RenameTable(
                name: "AdoptionApplications",
                newName: "AdoptionApplication");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VolunteerApplication",
                table: "VolunteerApplication",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdoptionApplication",
                table: "AdoptionApplication",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AnimalRescueAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalRescueAccount", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_AnimalRescueAccountRole_RoleId",
                table: "AnimalRescueAccountRole",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalRescueAccountRole");

            migrationBuilder.DropTable(
                name: "AnimalRescueAccount");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VolunteerApplication",
                table: "VolunteerApplication");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdoptionApplication",
                table: "AdoptionApplication");

            migrationBuilder.RenameTable(
                name: "VolunteerApplication",
                newName: "VolunteerApplications");

            migrationBuilder.RenameTable(
                name: "AdoptionApplication",
                newName: "AdoptionApplications");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VolunteerApplications",
                table: "VolunteerApplications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdoptionApplications",
                table: "AdoptionApplications",
                column: "Id");
        }
    }
}
