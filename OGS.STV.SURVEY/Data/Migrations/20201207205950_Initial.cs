using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OGS.STV.SURVEY.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CityOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    InsuranceOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCNO = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    CardNO = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyUserId = table.Column<int>(nullable: true),
                    MailSendStatus = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractId = table.Column<int>(nullable: true),
                    InsuranceId = table.Column<int>(nullable: true)
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
                    { 47, 47, "KAYSERİ" },
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
                    { 10, 10, "KOBİ Poliçeleri" },
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
                name: "ContractInsurances");

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
