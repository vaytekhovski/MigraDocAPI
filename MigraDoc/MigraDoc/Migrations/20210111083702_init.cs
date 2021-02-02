using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MigraDoc.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    addressArrivalCountry = table.Column<string>(nullable: true),
                    addressArea = table.Column<string>(nullable: true),
                    addressCity = table.Column<string>(nullable: true),
                    addressRegion = table.Column<string>(nullable: true),
                    addressHamlet = table.Column<string>(nullable: true),
                    addressVillage = table.Column<string>(nullable: true),
                    addressStreet = table.Column<string>(nullable: true),
                    addressHouseNumber = table.Column<string>(nullable: true),
                    addressBuildingNumber = table.Column<string>(nullable: true),
                    addressFlatNumber = table.Column<string>(nullable: true),
                    addressPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    serie = table.Column<string>(nullable: true),
                    number = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    place = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    educationOrgName = table.Column<string>(nullable: true),
                    educationEndYear = table.Column<int>(nullable: false),
                    diplomaNumber = table.Column<string>(nullable: true),
                    diplomaDate = table.Column<DateTime>(nullable: false),
                    educationCity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FullNames",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    firstName = table.Column<string>(nullable: true),
                    surname = table.Column<string>(nullable: true),
                    secondName = table.Column<string>(nullable: true),
                    engSurname = table.Column<string>(nullable: true),
                    engName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "isChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    surname = table.Column<bool>(nullable: false),
                    secondName = table.Column<bool>(nullable: false),
                    firstName = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_isChanges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KinsfolkWork",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    placeName = table.Column<string>(nullable: true),
                    position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KinsfolkWork", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MigrationCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    serie = table.Column<string>(nullable: true),
                    number = table.Column<string>(nullable: true),
                    issuingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MigrationCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MigrationRegs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    issuingDate = table.Column<DateTime>(nullable: false),
                    validityDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MigrationRegs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passports",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    issuingCountry = table.Column<string>(nullable: true),
                    serie = table.Column<string>(nullable: true),
                    number = table.Column<string>(nullable: true),
                    issueDate = table.Column<DateTime>(nullable: false),
                    issuingPlace = table.Column<string>(nullable: true),
                    validity = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RusLangDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    serie = table.Column<string>(nullable: true),
                    number = table.Column<string>(nullable: true),
                    issueDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RusLangDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    tgId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkAddress",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    addressCountry = table.Column<string>(nullable: true),
                    addressArea = table.Column<string>(nullable: true),
                    addressCity = table.Column<string>(nullable: true),
                    addressRegion = table.Column<string>(nullable: true),
                    addressHamlet = table.Column<string>(nullable: true),
                    addressVillage = table.Column<string>(nullable: true),
                    addressStreet = table.Column<string>(nullable: true),
                    addressHouseNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkFromWhos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    positionName = table.Column<string>(nullable: true),
                    workPeriod = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFromWhos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EducationId = table.Column<Guid>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationInfos_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    authorityName = table.Column<string>(nullable: true),
                    dateOfBirth = table.Column<DateTime>(nullable: false),
                    placeOfBirth = table.Column<string>(nullable: true),
                    citizenship = table.Column<string>(nullable: true),
                    dateOfGetCitithenship = table.Column<DateTime>(nullable: false),
                    nationality = table.Column<string>(nullable: true),
                    creed = table.Column<string>(nullable: true),
                    isChangeId = table.Column<Guid>(nullable: false),
                    sex = table.Column<int>(nullable: false),
                    fullNameId = table.Column<Guid>(nullable: false),
                    passportId = table.Column<Guid>(nullable: false),
                    addressId = table.Column<Guid>(nullable: false),
                    educationId = table.Column<Guid>(nullable: false),
                    degree = table.Column<int>(nullable: false),
                    maritalStatus = table.Column<int>(nullable: false),
                    migrationCardId = table.Column<Guid>(nullable: false),
                    rusLangDocumentId = table.Column<Guid>(nullable: false),
                    certificateId = table.Column<Guid>(nullable: false),
                    workFromWhoId = table.Column<Guid>(nullable: false),
                    migrationRegistrationId = table.Column<Guid>(nullable: false),
                    birthAddressId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_Addresses_addressId",
                        column: x => x.addressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_Addresses_birthAddressId",
                        column: x => x.birthAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_Certificates_certificateId",
                        column: x => x.certificateId,
                        principalTable: "Certificates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_Educations_educationId",
                        column: x => x.educationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_FullNames_fullNameId",
                        column: x => x.fullNameId,
                        principalTable: "FullNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_isChanges_isChangeId",
                        column: x => x.isChangeId,
                        principalTable: "isChanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_MigrationCards_migrationCardId",
                        column: x => x.migrationCardId,
                        principalTable: "MigrationCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_MigrationRegs_migrationRegistrationId",
                        column: x => x.migrationRegistrationId,
                        principalTable: "MigrationRegs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_Passports_passportId",
                        column: x => x.passportId,
                        principalTable: "Passports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_RusLangDocuments_rusLangDocumentId",
                        column: x => x.rusLangDocumentId,
                        principalTable: "RusLangDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_WorkFromWhos_workFromWhoId",
                        column: x => x.workFromWhoId,
                        principalTable: "WorkFromWhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressDuringWorks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    livePeriod = table.Column<string>(nullable: true),
                    addressCountry = table.Column<string>(nullable: true),
                    addressArea = table.Column<string>(nullable: true),
                    addressCity = table.Column<string>(nullable: true),
                    addressRegion = table.Column<string>(nullable: true),
                    addressHamlet = table.Column<string>(nullable: true),
                    addressVillage = table.Column<string>(nullable: true),
                    addressStreet = table.Column<string>(nullable: true),
                    addressHouseNumber = table.Column<string>(nullable: true),
                    addressBuildingNumber = table.Column<string>(nullable: true),
                    addressFlatNumber = table.Column<string>(nullable: true),
                    UserDetailId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressDuringWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressDuringWorks_UserDetails_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Changes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    changedFirstName = table.Column<string>(nullable: true),
                    changedSurname = table.Column<string>(nullable: true),
                    changedSecondName = table.Column<string>(nullable: true),
                    type = table.Column<int>(nullable: false),
                    reason = table.Column<int>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    UserDetailId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Changes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Changes_UserDetails_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    documentType = table.Column<int>(nullable: false),
                    documentStatus = table.Column<int>(nullable: false),
                    creationDate = table.Column<DateTime>(nullable: false),
                    UserDetailId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_UserDetails_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kinsfolks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    alive = table.Column<bool>(nullable: false),
                    sex = table.Column<int>(nullable: false),
                    childType = table.Column<int>(nullable: false),
                    firstName = table.Column<string>(nullable: true),
                    secondName = table.Column<string>(nullable: true),
                    surname = table.Column<string>(nullable: true),
                    countryOfBirth = table.Column<string>(nullable: true),
                    areOfBirth = table.Column<string>(nullable: true),
                    cityOfBirth = table.Column<string>(nullable: true),
                    regionOfBirth = table.Column<string>(nullable: true),
                    workId = table.Column<Guid>(nullable: false),
                    dateOfBirth = table.Column<DateTime>(nullable: false),
                    placeOfBirth = table.Column<string>(nullable: true),
                    citizenship = table.Column<string>(nullable: true),
                    addressId = table.Column<Guid>(nullable: false),
                    yearOfDeath = table.Column<int>(nullable: false),
                    placeOfWorkOrStudy = table.Column<string>(nullable: true),
                    positionOrSpeciality = table.Column<string>(nullable: true),
                    childNameAndOrganizationNumber = table.Column<string>(nullable: true),
                    UserDetailId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kinsfolks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kinsfolks_UserDetails_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kinsfolks_Addresses_addressId",
                        column: x => x.addressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kinsfolks_KinsfolkWork_workId",
                        column: x => x.workId,
                        principalTable: "KinsfolkWork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    period = table.Column<string>(nullable: true),
                    position = table.Column<string>(nullable: true),
                    placeName = table.Column<string>(nullable: true),
                    addressId = table.Column<Guid>(nullable: false),
                    UserDetailId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Works_UserDetails_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Works_WorkAddress_addressId",
                        column: x => x.addressId,
                        principalTable: "WorkAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressDuringWorks_UserDetailId",
                table: "AddressDuringWorks",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Changes_UserDetailId",
                table: "Changes",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_UserDetailId",
                table: "Documents",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationInfos_EducationId",
                table: "EducationInfos",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Kinsfolks_UserDetailId",
                table: "Kinsfolks",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Kinsfolks_addressId",
                table: "Kinsfolks",
                column: "addressId");

            migrationBuilder.CreateIndex(
                name: "IX_Kinsfolks_workId",
                table: "Kinsfolks",
                column: "workId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_UserId",
                table: "UserDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_addressId",
                table: "UserDetails",
                column: "addressId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_birthAddressId",
                table: "UserDetails",
                column: "birthAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_certificateId",
                table: "UserDetails",
                column: "certificateId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_educationId",
                table: "UserDetails",
                column: "educationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_fullNameId",
                table: "UserDetails",
                column: "fullNameId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_isChangeId",
                table: "UserDetails",
                column: "isChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_migrationCardId",
                table: "UserDetails",
                column: "migrationCardId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_migrationRegistrationId",
                table: "UserDetails",
                column: "migrationRegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_passportId",
                table: "UserDetails",
                column: "passportId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_rusLangDocumentId",
                table: "UserDetails",
                column: "rusLangDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_workFromWhoId",
                table: "UserDetails",
                column: "workFromWhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_UserDetailId",
                table: "Works",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_addressId",
                table: "Works",
                column: "addressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressDuringWorks");

            migrationBuilder.DropTable(
                name: "Changes");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "EducationInfos");

            migrationBuilder.DropTable(
                name: "Kinsfolks");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "KinsfolkWork");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "WorkAddress");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "FullNames");

            migrationBuilder.DropTable(
                name: "isChanges");

            migrationBuilder.DropTable(
                name: "MigrationCards");

            migrationBuilder.DropTable(
                name: "MigrationRegs");

            migrationBuilder.DropTable(
                name: "Passports");

            migrationBuilder.DropTable(
                name: "RusLangDocuments");

            migrationBuilder.DropTable(
                name: "WorkFromWhos");
        }
    }
}
