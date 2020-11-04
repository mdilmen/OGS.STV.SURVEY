﻿using Microsoft.EntityFrameworkCore.Migrations;

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

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityOrder", "Name" },
                values: new object[,]
                {
                    { 101, 1, "ADANA" },
                    { 59, 59, "MUĞLA" },
                    { 58, 58, "MERSİN" },
                    { 57, 57, "MARDİN" },
                    { 56, 56, "MANİSA" },
                    { 55, 55, "MALATYA" },
                    { 54, 54, "KÜTAHYA" },
                    { 53, 53, "KONYA" },
                    { 60, 60, "MUŞ" },
                    { 52, 52, "KOCAELİ" },
                    { 50, 50, "KIRŞEHİR" },
                    { 49, 49, "KIRKLARELİ" },
                    { 48, 48, "KIRIKKALE" },
                    { 47, 47, "KAYSERİ" },
                    { 46, 46, "KASTAMONU" },
                    { 45, 45, "KARS" },
                    { 44, 44, "KARAMAN" },
                    { 51, 51, "KİLİS" },
                    { 61, 61, "NEVŞEHİR" },
                    { 62, 62, "NİĞDE" },
                    { 63, 63, "ORDU" },
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
                    { 65, 65, "RİZE" },
                    { 64, 64, "OSMANİYE" },
                    { 43, 43, "KARABÜK" },
                    { 42, 42, "KAHRAMANMARAŞ" },
                    { 3, 41, "İZMİR" },
                    { 1, 40, "İSTANBUL" },
                    { 18, 18, "BİTLİS" },
                    { 17, 17, "BİNGÖL" },
                    { 16, 16, "BİLECİK" },
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
                    { 81, 81, "ZONGULDAK" },
                    { 20, 20, "BURDUR" },
                    { 22, 22, "ÇANAKKALE" },
                    { 39, 39, "ISPARTA" },
                    { 38, 38, "IĞDIR" },
                    { 6, 37, "HATAY" },
                    { 36, 36, "HAKKARİ" },
                    { 35, 35, "GÜMÜŞHANE" },
                    { 34, 34, "GİRESUN" },
                    { 33, 33, "GAZİANTEP" },
                    { 32, 32, "ESKİŞEHİR" },
                    { 31, 31, "ERZURUM" },
                    { 30, 30, "ERZİNCAN" },
                    { 29, 29, "ELAZIĞ" },
                    { 28, 28, "EDİRNE" },
                    { 27, 27, "DÜZCE" },
                    { 8, 26, "DİYARBAKIR" },
                    { 25, 25, "DENİZLİ" },
                    { 24, 24, "ÇORUM" },
                    { 23, 23, "ÇANKIRI" },
                    { 21, 21, "BURSA" },
                    { 9, 82, "Diğer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
