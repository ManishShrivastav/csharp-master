﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFConsoleUI.Migrations
{
    public partial class ImprovedColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddresses_Contacts_ContactId",
                table: "EmailAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Contacts_ContactId",
                table: "PhoneNumbers");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "PhoneNumbers",
                newName: "ContactID");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_ContactId",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_ContactID");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "PhoneNumbers",
                type: "varchar(20",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContactID",
                table: "PhoneNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "EmailAddresses",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "EmailAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contacts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddresses_Contacts_ContactId",
                table: "EmailAddresses",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Contacts_ContactID",
                table: "PhoneNumbers",
                column: "ContactID",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddresses_Contacts_ContactId",
                table: "EmailAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Contacts_ContactID",
                table: "PhoneNumbers");

            migrationBuilder.RenameColumn(
                name: "ContactID",
                table: "PhoneNumbers",
                newName: "ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_ContactID",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_ContactId");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "PhoneNumbers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "PhoneNumbers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "EmailAddresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "EmailAddresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddresses_Contacts_ContactId",
                table: "EmailAddresses",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Contacts_ContactId",
                table: "PhoneNumbers",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id");
        }
    }
}
