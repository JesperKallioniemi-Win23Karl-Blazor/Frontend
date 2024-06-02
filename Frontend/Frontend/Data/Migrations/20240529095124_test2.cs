using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frontend.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "UserProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "UserProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "UserProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "UserProfiles",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "UserProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "UserProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "UserProfiles");
        }
    }
}
