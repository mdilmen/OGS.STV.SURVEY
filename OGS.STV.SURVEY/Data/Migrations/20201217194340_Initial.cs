using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OGS.STV.SURVEY.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailSend = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "SurveyUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    CardNO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyUsers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyUserId = table.Column<int>(type: "int", nullable: true),
                    MailSendStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_SurveyUsers_SurveyUserId",
                        column: x => x.SurveyUserId,
                        principalTable: "SurveyUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractInsurances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractId = table.Column<int>(type: "int", nullable: true),
                    InsuranceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractInsurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractInsurances_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractInsurances_Insurances_InsuranceId",
                        column: x => x.InsuranceId,
                        principalTable: "Insurances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityOrder", "Name" },
                values: new object[,]
                {
                    { 101, 1, "ADANA" },
                    { 61, 61, "NEVŞEHİR" },
                    { 60, 60, "MUŞ" },
                    { 59, 59, "MUĞLA" },
                    { 58, 58, "MERSİN" },
                    { 57, 57, "MARDİN" },
                    { 56, 56, "MANİSA" },
                    { 55, 55, "MALATYA" },
                    { 54, 54, "KÜTAHYA" },
                    { 53, 53, "KONYA" },
                    { 52, 52, "KOCAELİ" },
                    { 51, 51, "KİLİS" },
                    { 50, 50, "KIRŞEHİR" },
                    { 49, 49, "KIRKLARELİ" },
                    { 48, 48, "KIRIKKALE" },
                    { 46, 46, "KASTAMONU" },
                    { 45, 45, "KARS" },
                    { 44, 44, "KARAMAN" },
                    { 62, 62, "NİĞDE" },
                    { 43, 43, "KARABÜK" },
                    { 63, 63, "ORDU" },
                    { 65, 65, "RİZE" },
                    { 9, 82, "Diğer" },
                    { 81, 81, "ZONGULDAK" },
                    { 80, 80, "YOZGAT" },
                    { 79, 79, "YALOVA" },
                    { 7, 78, "VAN" },
                    { 77, 77, "UŞAK" },
                    { 76, 76, "TUNCELİ" },
                    { 75, 75, "TRABZON" },
                    { 74, 74, "TOKAT" },
                    { 5, 73, "TEKİRDAĞ" },
                    { 72, 72, "ŞIRNAK" },
                    { 71, 71, "ŞANLIURFA" },
                    { 70, 70, "SİVAS" },
                    { 69, 69, "SİNOP" },
                    { 68, 68, "SİİRT" },
                    { 67, 67, "SAMSUN" },
                    { 66, 66, "SAKARYA" },
                    { 64, 64, "OSMANİYE" },
                    { 42, 42, "KAHRAMANMARAŞ" },
                    { 47, 47, "KAYSERİ" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityOrder", "Name" },
                values: new object[,]
                {
                    { 1, 40, "İSTANBUL" },
                    { 18, 18, "BİTLİS" },
                    { 17, 17, "BİNGÖL" },
                    { 3, 41, "İZMİR" },
                    { 15, 15, "BAYBURT" },
                    { 14, 14, "BATMAN" },
                    { 13, 13, "BARTIN" },
                    { 12, 12, "BALIKESİR" },
                    { 11, 11, "AYDIN" },
                    { 10, 10, "ARTVİN" },
                    { 109, 9, "ARDAHAN" },
                    { 4, 8, "ANTALYA" },
                    { 2, 7, "ANKARA" },
                    { 106, 6, "AMASYA" },
                    { 105, 5, "AKSARAY" },
                    { 104, 4, "AĞRI" },
                    { 103, 3, "AFYONKARAHİSAR" },
                    { 102, 2, "ADIYAMAN" },
                    { 19, 19, "BOLU" },
                    { 20, 20, "BURDUR" },
                    { 16, 16, "BİLECİK" },
                    { 22, 22, "ÇANAKKALE" },
                    { 39, 39, "ISPARTA" },
                    { 38, 38, "IĞDIR" },
                    { 6, 37, "HATAY" },
                    { 21, 21, "BURSA" },
                    { 36, 36, "HAKKARİ" },
                    { 35, 35, "GÜMÜŞHANE" },
                    { 34, 34, "GİRESUN" },
                    { 32, 32, "ESKİŞEHİR" },
                    { 33, 33, "GAZİANTEP" },
                    { 30, 30, "ERZİNCAN" },
                    { 29, 29, "ELAZIĞ" },
                    { 28, 28, "EDİRNE" },
                    { 27, 27, "DÜZCE" },
                    { 8, 26, "DİYARBAKIR" },
                    { 25, 25, "DENİZLİ" },
                    { 24, 24, "ÇORUM" },
                    { 23, 23, "ÇANKIRI" },
                    { 31, 31, "ERZURUM" }
                });

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "Id", "InsuranceOrder", "Name" },
                values: new object[,]
                {
                    { 7, 7, "ÖSS (Özel Sağlık Sigortaları)" },
                    { 10, 10, "KOBİ Poliçeleri" }
                });

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "Id", "InsuranceOrder", "Name" },
                values: new object[,]
                {
                    { 9, 9, "Eşyam Sigortası" },
                    { 8, 8, "Seyahat Sigortaları" },
                    { 6, 6, "TSS (Tamamlayıcı Sağlık Sigortaları)" },
                    { 11, 11, "YSS (Yabancılar Sağlık Sigortaları)" },
                    { 4, 4, "Konut Sigortaları " },
                    { 3, 3, "Diğer hayat sigortaları / Ferdi Kaza ürünleri" },
                    { 2, 2, "Eğitim Sigortaları" },
                    { 1, 1, "Kredi Hayat Sigortaları" },
                    { 5, 5, "Kasko ve Trafik Sigortaları" },
                    { 12, 12, "BES (Bireysel Emeklilik)" }
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
                name: "IX_ContractInsurances_ContractId",
                table: "ContractInsurances",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractInsurances_InsuranceId",
                table: "ContractInsurances",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_SurveyUserId",
                table: "Contracts",
                column: "SurveyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyUsers_CityId",
                table: "SurveyUsers",
                column: "CityId");
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
                name: "ContractInsurances");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "SurveyUsers");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
