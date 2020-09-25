using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MigraDoc.Core.Migrations
{
    public partial class familystatusid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FamilyStatusId",
                table: "UserDatas",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserEntityid",
                table: "Relatives",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IssueDate",
                table: "IdentityDocuments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserEntityid",
                table: "Documents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserDatas_FamilyStatusId",
                table: "UserDatas",
                column: "FamilyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_UserEntityid",
                table: "Relatives",
                column: "UserEntityid");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_UserEntityid",
                table: "Documents",
                column: "UserEntityid");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Users_UserEntityid",
                table: "Documents",
                column: "UserEntityid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relatives_Users_UserEntityid",
                table: "Relatives",
                column: "UserEntityid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDatas_FamilyStatuses_FamilyStatusId",
                table: "UserDatas",
                column: "FamilyStatusId",
                principalTable: "FamilyStatuses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Users_UserEntityid",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Relatives_Users_UserEntityid",
                table: "Relatives");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDatas_FamilyStatuses_FamilyStatusId",
                table: "UserDatas");

            migrationBuilder.DropIndex(
                name: "IX_UserDatas_FamilyStatusId",
                table: "UserDatas");

            migrationBuilder.DropIndex(
                name: "IX_Relatives_UserEntityid",
                table: "Relatives");

            migrationBuilder.DropIndex(
                name: "IX_Documents_UserEntityid",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "FamilyStatusId",
                table: "UserDatas");

            migrationBuilder.DropColumn(
                name: "UserEntityid",
                table: "Relatives");

            migrationBuilder.DropColumn(
                name: "UserEntityid",
                table: "Documents");

            migrationBuilder.AlterColumn<string>(
                name: "IssueDate",
                table: "IdentityDocuments",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
