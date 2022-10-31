using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace animalrescue.mainmodule.dal.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class TestDateOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AnimalRescueAccount",
                type: "TEXT",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "AnimalRescueAccount",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "AnimalRescueAccount",
                type: "TEXT",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AnimalRescueAccount",
                type: "TEXT",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AnimalRescueAccount",
                type: "TEXT",
                maxLength: 55,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AnimalRescueAccount",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AnimalRescueAccount",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "AnimalRescueAccount",
                type: "TEXT",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AnimalRescueAccount",
                type: "TEXT",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "AnimalRescueAccount",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AnimalRescueAccount",
                type: "TEXT",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AnimalRescueAccount",
                type: "TEXT",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "AnimalRescueAccount",
                type: "TEXT",
                maxLength: 10,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address1",
                table: "AnimalRescueAccount");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "AnimalRescueAccount");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AnimalRescueAccount");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AnimalRescueAccount");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AnimalRescueAccount");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AnimalRescueAccount");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "AnimalRescueAccount");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AnimalRescueAccount");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "AnimalRescueAccount");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AnimalRescueAccount");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AnimalRescueAccount");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "AnimalRescueAccount");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AnimalRescueAccount",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 150,
                oldNullable: true);
        }
    }
}
