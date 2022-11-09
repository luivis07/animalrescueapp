using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace animalrescue.mainmodule.dal.Migrations.SqlServerMigrations
{
    /// <inheritdoc />
    public partial class locationcalendar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "CalendarType",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "Location",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Location",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Location",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Location",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Location",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Location",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Location",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Location",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CalendarType",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "SerializedInfo",
                table: "Calendar",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address1",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CalendarType");

            migrationBuilder.DropColumn(
                name: "SerializedInfo",
                table: "Calendar");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CalendarType",
                newName: "name");
        }
    }
}
