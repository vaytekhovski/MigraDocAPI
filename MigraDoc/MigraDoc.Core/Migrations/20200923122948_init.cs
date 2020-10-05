using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MigraDoc.Core.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    index = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Sity = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Build = table.Column<string>(nullable: true),
                    Housing = table.Column<string>(nullable: true),
                    Flat = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EducationLevels",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Doshkolnoe = table.Column<bool>(nullable: false),
                    NachalnoeObshee = table.Column<bool>(nullable: false),
                    OsnovnoeObshee = table.Column<bool>(nullable: false),
                    SredneeObshee = table.Column<bool>(nullable: false),
                    SredneeProfessionalnoe = table.Column<bool>(nullable: false),
                    VissheeBakalavriat = table.Column<bool>(nullable: false),
                    VissheeSpecialitetMagistratura = table.Column<bool>(nullable: false),
                    VissheePodgotovkaKadrov = table.Column<bool>(nullable: false),
                    KandidatNauk = table.Column<bool>(nullable: false),
                    DoktorNauk = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Sertificate = table.Column<string>(nullable: true),
                    Present = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FamilyStatuses",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    MarriageCertificateNumber = table.Column<string>(nullable: true),
                    IssueDate = table.Column<DateTime>(nullable: false),
                    IssuePlace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyStatuses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityDocuments",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    Series = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    IssueDate = table.Column<string>(nullable: true),
                    IssueAgency = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityDocuments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    amount = table.Column<decimal>(nullable: false),
                    currency = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    DateOfReceiving = table.Column<DateTime>(nullable: false),
                    DateIsUnknown = table.Column<bool>(nullable: false),
                    HandlyDateOfReceiving = table.Column<string>(nullable: true),
                    PlaceOfReceiving = table.Column<string>(nullable: true),
                    StatelessPerson = table.Column<bool>(nullable: false),
                    LossReason = table.Column<string>(nullable: true),
                    LossCountry = table.Column<string>(nullable: true),
                    LossDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RussianKnowledges",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    SertificateName = table.Column<string>(nullable: true),
                    RussianKnowledge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RussianKnowledges", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UnreleasedConvictions",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Place = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Term = table.Column<TimeSpan>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnreleasedConvictions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    telegramUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "WorkPermits",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Series = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    IssueDate = table.Column<DateTime>(nullable: false),
                    ExpiresDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPermits", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "IncomeLists",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    MainIncomeId = table.Column<Guid>(nullable: false),
                    OtherIncomeId = table.Column<Guid>(nullable: false),
                    BankDepositId = table.Column<Guid>(nullable: false),
                    SecuritiesId = table.Column<Guid>(nullable: false),
                    SocialPaymentsId = table.Column<Guid>(nullable: false),
                    OtherId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeLists", x => x.id);
                    table.ForeignKey(
                        name: "FK_IncomeLists_Incomes_BankDepositId",
                        column: x => x.BankDepositId,
                        principalTable: "Incomes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncomeLists_Incomes_MainIncomeId",
                        column: x => x.MainIncomeId,
                        principalTable: "Incomes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncomeLists_Incomes_OtherId",
                        column: x => x.OtherId,
                        principalTable: "Incomes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncomeLists_Incomes_OtherIncomeId",
                        column: x => x.OtherIncomeId,
                        principalTable: "Incomes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncomeLists_Incomes_SecuritiesId",
                        column: x => x.SecuritiesId,
                        principalTable: "Incomes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncomeLists_Incomes_SocialPaymentsId",
                        column: x => x.SocialPaymentsId,
                        principalTable: "Incomes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDatas",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Sex = table.Column<int>(nullable: false),
                    EducationId = table.Column<Guid>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    MiddleNameAbsent = table.Column<bool>(nullable: false),
                    EngFirstName = table.Column<string>(nullable: true),
                    EngSurname = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    CountryOfBirth = table.Column<string>(nullable: true),
                    PlaceOfBirth = table.Column<string>(nullable: true),
                    CitizenshipId = table.Column<Guid>(nullable: false),
                    Creed = table.Column<string>(nullable: true),
                    IdentityDocumentId = table.Column<Guid>(nullable: false),
                    EducationLevelId = table.Column<Guid>(nullable: false),
                    WorkPermitId = table.Column<Guid>(nullable: false),
                    IncomeId = table.Column<Guid>(nullable: false),
                    UnreleasedConvictionId = table.Column<Guid>(nullable: false),
                    ResidenceAddressId = table.Column<Guid>(nullable: false),
                    RussianKnowledgeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDatas", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserDatas_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDatas_EducationLevels_EducationLevelId",
                        column: x => x.EducationLevelId,
                        principalTable: "EducationLevels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDatas_IdentityDocuments_IdentityDocumentId",
                        column: x => x.IdentityDocumentId,
                        principalTable: "IdentityDocuments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDatas_IncomeLists_IncomeId",
                        column: x => x.IncomeId,
                        principalTable: "IncomeLists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDatas_Nationalities_CitizenshipId",
                        column: x => x.CitizenshipId,
                        principalTable: "Nationalities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDatas_Addresses_ResidenceAddressId",
                        column: x => x.ResidenceAddressId,
                        principalTable: "Addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDatas_RussianKnowledges_RussianKnowledgeId",
                        column: x => x.RussianKnowledgeId,
                        principalTable: "RussianKnowledges",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDatas_UnreleasedConvictions_UnreleasedConvictionId",
                        column: x => x.UnreleasedConvictionId,
                        principalTable: "UnreleasedConvictions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDatas_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDatas_WorkPermits_WorkPermitId",
                        column: x => x.WorkPermitId,
                        principalTable: "WorkPermits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    DocumentBase = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    UserDataEntityid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.id);
                    table.ForeignKey(
                        name: "FK_Documents_UserDatas_UserDataEntityid",
                        column: x => x.UserDataEntityid,
                        principalTable: "UserDatas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NameChanges",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    PreviusFirstName = table.Column<string>(nullable: true),
                    PreviusSurname = table.Column<string>(nullable: true),
                    PreviusMiddleName = table.Column<string>(nullable: true),
                    ChangeReason = table.Column<int>(nullable: false),
                    ChangeDate = table.Column<DateTime>(nullable: false),
                    UserDataEntityid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NameChanges", x => x.id);
                    table.ForeignKey(
                        name: "FK_NameChanges_UserDatas_UserDataEntityid",
                        column: x => x.UserDataEntityid,
                        principalTable: "UserDatas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Relatives",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    KinsfolkType = table.Column<int>(nullable: false),
                    alive = table.Column<bool>(nullable: false),
                    ChildType = table.Column<int>(nullable: false),
                    SexType = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    MiddleNameAbsent = table.Column<bool>(nullable: false),
                    MiddleName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    CitizenshipId = table.Column<Guid>(nullable: false),
                    PlaceOfBirth = table.Column<string>(nullable: true),
                    CountryOfResidenceId = table.Column<Guid>(nullable: false),
                    WorkOrStudyPosition = table.Column<string>(nullable: true),
                    WorkOrStudyOrganizationName = table.Column<string>(nullable: true),
                    UserDataEntityid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatives", x => x.id);
                    table.ForeignKey(
                        name: "FK_Relatives_Addresses_CountryOfResidenceId",
                        column: x => x.CountryOfResidenceId,
                        principalTable: "Addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Relatives_Nationalities_CitizenshipId",
                        column: x => x.CitizenshipId,
                        principalTable: "Nationalities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Relatives_UserDatas_UserDataEntityid",
                        column: x => x.UserDataEntityid,
                        principalTable: "UserDatas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    OrganizationName = table.Column<string>(nullable: true),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: true),
                    AddressId = table.Column<Guid>(nullable: false),
                    UserDataEntityid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.id);
                    table.ForeignKey(
                        name: "FK_Works_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Works_UserDatas_UserDataEntityid",
                        column: x => x.UserDataEntityid,
                        principalTable: "UserDatas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_UserDataEntityid",
                table: "Documents",
                column: "UserDataEntityid");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeLists_BankDepositId",
                table: "IncomeLists",
                column: "BankDepositId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeLists_MainIncomeId",
                table: "IncomeLists",
                column: "MainIncomeId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeLists_OtherId",
                table: "IncomeLists",
                column: "OtherId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeLists_OtherIncomeId",
                table: "IncomeLists",
                column: "OtherIncomeId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeLists_SecuritiesId",
                table: "IncomeLists",
                column: "SecuritiesId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeLists_SocialPaymentsId",
                table: "IncomeLists",
                column: "SocialPaymentsId");

            migrationBuilder.CreateIndex(
                name: "IX_NameChanges_UserDataEntityid",
                table: "NameChanges",
                column: "UserDataEntityid");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_CountryOfResidenceId",
                table: "Relatives",
                column: "CountryOfResidenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_CitizenshipId",
                table: "Relatives",
                column: "CitizenshipId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_UserDataEntityid",
                table: "Relatives",
                column: "UserDataEntityid");

            migrationBuilder.CreateIndex(
                name: "IX_UserDatas_EducationId",
                table: "UserDatas",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDatas_EducationLevelId",
                table: "UserDatas",
                column: "EducationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDatas_IdentityDocumentId",
                table: "UserDatas",
                column: "IdentityDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDatas_IncomeId",
                table: "UserDatas",
                column: "IncomeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDatas_CitizenshipId",
                table: "UserDatas",
                column: "CitizenshipId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDatas_ResidenceAddressId",
                table: "UserDatas",
                column: "ResidenceAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDatas_RussianKnowledgeId",
                table: "UserDatas",
                column: "RussianKnowledgeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDatas_UnreleasedConvictionId",
                table: "UserDatas",
                column: "UnreleasedConvictionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDatas_UserId",
                table: "UserDatas",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDatas_WorkPermitId",
                table: "UserDatas",
                column: "WorkPermitId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_AddressId",
                table: "Works",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_UserDataEntityid",
                table: "Works",
                column: "UserDataEntityid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "FamilyStatuses");

            migrationBuilder.DropTable(
                name: "NameChanges");

            migrationBuilder.DropTable(
                name: "Relatives");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "UserDatas");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "EducationLevels");

            migrationBuilder.DropTable(
                name: "IdentityDocuments");

            migrationBuilder.DropTable(
                name: "IncomeLists");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "RussianKnowledges");

            migrationBuilder.DropTable(
                name: "UnreleasedConvictions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WorkPermits");

            migrationBuilder.DropTable(
                name: "Incomes");
        }
    }
}
