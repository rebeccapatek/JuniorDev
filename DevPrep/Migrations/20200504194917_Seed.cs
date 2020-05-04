using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevPrep.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoftwareLanguages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareLanguages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterviewQuestions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewQuestions", x => x.id);
                    table.ForeignKey(
                        name: "FK_InterviewQuestions_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Concepts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SoftwareLanguageId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concepts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Concepts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Concepts_SoftwareLanguages_SoftwareLanguageId",
                        column: x => x.SoftwareLanguageId,
                        principalTable: "SoftwareLanguages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VocabWords",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(nullable: true),
                    Definition = table.Column<string>(nullable: true),
                    SoftwareLanguageId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocabWords", x => x.id);
                    table.ForeignKey(
                        name: "FK_VocabWords_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VocabWords_SoftwareLanguages_SoftwareLanguageId",
                        column: x => x.SoftwareLanguageId,
                        principalTable: "SoftwareLanguages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConceptId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    Paragraph = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Descriptions_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Descriptions_Concepts_ConceptId",
                        column: x => x.ConceptId,
                        principalTable: "Concepts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsefulLinks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    ConceptId = table.Column<int>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    InterviewQuestionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsefulLinks", x => x.id);
                    table.ForeignKey(
                        name: "FK_UsefulLinks_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsefulLinks_Concepts_ConceptId",
                        column: x => x.ConceptId,
                        principalTable: "Concepts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsefulLinks_InterviewQuestions_InterviewQuestionId",
                        column: x => x.InterviewQuestionId,
                        principalTable: "InterviewQuestions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "49cd9881-5347-45f8-9e4c-4d6c09988777", "ApplicationUser", "rebs@rebs.com", true, false, null, "REBS@REBS.COM", "REBS@REBS.COM", "AQAAAAEAACcQAAAAEPbfvnAycWJHaxkaYKhdKhexW43wCPL22yhFFzSPQ2C2mEY+U2UjV100/hwcOpWSvg==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "rebs@rebs.com", "Rebecca", "Patek" });

            migrationBuilder.InsertData(
                table: "SoftwareLanguages",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { 1, "HTML" },
                    { 2, "CSS" },
                    { 3, "Javascript" },
                    { 4, "React" },
                    { 5, "Github" },
                    { 6, "Slack" },
                    { 7, "Csharp" },
                    { 8, "SQL" },
                    { 9, "General Concepts" },
                    { 10, "DotNet" },
                    { 11, "Bootstrap" }
                });

            migrationBuilder.InsertData(
                table: "Concepts",
                columns: new[] { "id", "ApplicationUserId", "Name", "SoftwareLanguageId" },
                values: new object[,]
                {
                    { 3, "00000000-ffff-ffff-ffff-ffffffffffff", "Anchor tags", 1 },
                    { 1, "00000000-ffff-ffff-ffff-ffffffffffff", "Map", 3 },
                    { 2, "00000000-ffff-ffff-ffff-ffffffffffff", "If/else", 3 }
                });

            migrationBuilder.InsertData(
                table: "VocabWords",
                columns: new[] { "id", "ApplicationUserId", "Definition", "SoftwareLanguageId", "Word" },
                values: new object[,]
                {
                    { 1, "00000000-ffff-ffff-ffff-ffffffffffff", "Something", 1, "Object" },
                    { 2, "00000000-ffff-ffff-ffff-ffffffffffff", "Ware that is Soft", 1, "Software" },
                    { 3, "00000000-ffff-ffff-ffff-ffffffffffff", "way to get around something", 1, "Trick" },
                    { 4, "00000000-ffff-ffff-ffff-ffffffffffff", "Cascading Style Sheets", 2, "C.S.S." }
                });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "id", "ApplicationUserId", "ConceptId", "Paragraph" },
                values: new object[,]
                {
                    { 1, "00000000-ffff-ffff-ffff-ffffffffffff", 1, "Alows you to go through each object and get the data on it" },
                    { 2, "00000000-ffff-ffff-ffff-ffffffffffff", 1, "This is really helpful to use" },
                    { 3, "00000000-ffff-ffff-ffff-ffffffffffff", 2, "This tells the computer to try the statement after the if in () and if that's true run the {} if it's false then run the else {}" }
                });

            migrationBuilder.InsertData(
                table: "UsefulLinks",
                columns: new[] { "id", "ApplicationUserId", "ConceptId", "InterviewQuestionId", "Link", "Title" },
                values: new object[,]
                {
                    { 1, "00000000-ffff-ffff-ffff-ffffffffffff", 1, null, "www.youtube.com", "Here is a great youtube that explains maping" },
                    { 2, "00000000-ffff-ffff-ffff-ffffffffffff", 1, null, "www.wsj.com", "I love this article on mapping" },
                    { 3, "00000000-ffff-ffff-ffff-ffffffffffff", 2, null, "www.youtube.com", "Watch this youtube to review how to do an if/esle" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Concepts_ApplicationUserId",
                table: "Concepts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Concepts_SoftwareLanguageId",
                table: "Concepts",
                column: "SoftwareLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_ApplicationUserId",
                table: "Descriptions",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_ConceptId",
                table: "Descriptions",
                column: "ConceptId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewQuestions_ApplicationUserId",
                table: "InterviewQuestions",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsefulLinks_ApplicationUserId",
                table: "UsefulLinks",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsefulLinks_ConceptId",
                table: "UsefulLinks",
                column: "ConceptId");

            migrationBuilder.CreateIndex(
                name: "IX_UsefulLinks_InterviewQuestionId",
                table: "UsefulLinks",
                column: "InterviewQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_VocabWords_ApplicationUserId",
                table: "VocabWords",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_VocabWords_SoftwareLanguageId",
                table: "VocabWords",
                column: "SoftwareLanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropTable(
                name: "UsefulLinks");

            migrationBuilder.DropTable(
                name: "VocabWords");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Concepts");

            migrationBuilder.DropTable(
                name: "InterviewQuestions");

            migrationBuilder.DropTable(
                name: "SoftwareLanguages");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
