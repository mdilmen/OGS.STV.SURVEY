﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OGS.STV.SURVEY.Data;

namespace OGS.STV.SURVEY.Data.Migrations
{
    [DbContext(typeof(SurveyDbContext))]
    [Migration("20201112082056_Fifth")]
    partial class Fifth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OGS.STV.SURVEY.Data.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            CityOrder = 1,
                            Name = "ADANA"
                        },
                        new
                        {
                            Id = 102,
                            CityOrder = 2,
                            Name = "ADIYAMAN"
                        },
                        new
                        {
                            Id = 103,
                            CityOrder = 3,
                            Name = "AFYONKARAHİSAR"
                        },
                        new
                        {
                            Id = 104,
                            CityOrder = 4,
                            Name = "AĞRI"
                        },
                        new
                        {
                            Id = 105,
                            CityOrder = 5,
                            Name = "AKSARAY"
                        },
                        new
                        {
                            Id = 106,
                            CityOrder = 6,
                            Name = "AMASYA"
                        },
                        new
                        {
                            Id = 2,
                            CityOrder = 7,
                            Name = "ANKARA"
                        },
                        new
                        {
                            Id = 4,
                            CityOrder = 8,
                            Name = "ANTALYA"
                        },
                        new
                        {
                            Id = 109,
                            CityOrder = 9,
                            Name = "ARDAHAN"
                        },
                        new
                        {
                            Id = 10,
                            CityOrder = 10,
                            Name = "ARTVİN"
                        },
                        new
                        {
                            Id = 11,
                            CityOrder = 11,
                            Name = "AYDIN"
                        },
                        new
                        {
                            Id = 12,
                            CityOrder = 12,
                            Name = "BALIKESİR"
                        },
                        new
                        {
                            Id = 13,
                            CityOrder = 13,
                            Name = "BARTIN"
                        },
                        new
                        {
                            Id = 14,
                            CityOrder = 14,
                            Name = "BATMAN"
                        },
                        new
                        {
                            Id = 15,
                            CityOrder = 15,
                            Name = "BAYBURT"
                        },
                        new
                        {
                            Id = 16,
                            CityOrder = 16,
                            Name = "BİLECİK"
                        },
                        new
                        {
                            Id = 17,
                            CityOrder = 17,
                            Name = "BİNGÖL"
                        },
                        new
                        {
                            Id = 18,
                            CityOrder = 18,
                            Name = "BİTLİS"
                        },
                        new
                        {
                            Id = 19,
                            CityOrder = 19,
                            Name = "BOLU"
                        },
                        new
                        {
                            Id = 20,
                            CityOrder = 20,
                            Name = "BURDUR"
                        },
                        new
                        {
                            Id = 21,
                            CityOrder = 21,
                            Name = "BURSA"
                        },
                        new
                        {
                            Id = 22,
                            CityOrder = 22,
                            Name = "ÇANAKKALE"
                        },
                        new
                        {
                            Id = 23,
                            CityOrder = 23,
                            Name = "ÇANKIRI"
                        },
                        new
                        {
                            Id = 24,
                            CityOrder = 24,
                            Name = "ÇORUM"
                        },
                        new
                        {
                            Id = 25,
                            CityOrder = 25,
                            Name = "DENİZLİ"
                        },
                        new
                        {
                            Id = 8,
                            CityOrder = 26,
                            Name = "DİYARBAKIR"
                        },
                        new
                        {
                            Id = 27,
                            CityOrder = 27,
                            Name = "DÜZCE"
                        },
                        new
                        {
                            Id = 28,
                            CityOrder = 28,
                            Name = "EDİRNE"
                        },
                        new
                        {
                            Id = 29,
                            CityOrder = 29,
                            Name = "ELAZIĞ"
                        },
                        new
                        {
                            Id = 30,
                            CityOrder = 30,
                            Name = "ERZİNCAN"
                        },
                        new
                        {
                            Id = 31,
                            CityOrder = 31,
                            Name = "ERZURUM"
                        },
                        new
                        {
                            Id = 32,
                            CityOrder = 32,
                            Name = "ESKİŞEHİR"
                        },
                        new
                        {
                            Id = 33,
                            CityOrder = 33,
                            Name = "GAZİANTEP"
                        },
                        new
                        {
                            Id = 34,
                            CityOrder = 34,
                            Name = "GİRESUN"
                        },
                        new
                        {
                            Id = 35,
                            CityOrder = 35,
                            Name = "GÜMÜŞHANE"
                        },
                        new
                        {
                            Id = 36,
                            CityOrder = 36,
                            Name = "HAKKARİ"
                        },
                        new
                        {
                            Id = 6,
                            CityOrder = 37,
                            Name = "HATAY"
                        },
                        new
                        {
                            Id = 38,
                            CityOrder = 38,
                            Name = "IĞDIR"
                        },
                        new
                        {
                            Id = 39,
                            CityOrder = 39,
                            Name = "ISPARTA"
                        },
                        new
                        {
                            Id = 1,
                            CityOrder = 40,
                            Name = "İSTANBUL"
                        },
                        new
                        {
                            Id = 3,
                            CityOrder = 41,
                            Name = "İZMİR"
                        },
                        new
                        {
                            Id = 42,
                            CityOrder = 42,
                            Name = "KAHRAMANMARAŞ"
                        },
                        new
                        {
                            Id = 43,
                            CityOrder = 43,
                            Name = "KARABÜK"
                        },
                        new
                        {
                            Id = 44,
                            CityOrder = 44,
                            Name = "KARAMAN"
                        },
                        new
                        {
                            Id = 45,
                            CityOrder = 45,
                            Name = "KARS"
                        },
                        new
                        {
                            Id = 46,
                            CityOrder = 46,
                            Name = "KASTAMONU"
                        },
                        new
                        {
                            Id = 47,
                            CityOrder = 47,
                            Name = "KAYSERİ"
                        },
                        new
                        {
                            Id = 48,
                            CityOrder = 48,
                            Name = "KIRIKKALE"
                        },
                        new
                        {
                            Id = 49,
                            CityOrder = 49,
                            Name = "KIRKLARELİ"
                        },
                        new
                        {
                            Id = 50,
                            CityOrder = 50,
                            Name = "KIRŞEHİR"
                        },
                        new
                        {
                            Id = 51,
                            CityOrder = 51,
                            Name = "KİLİS"
                        },
                        new
                        {
                            Id = 52,
                            CityOrder = 52,
                            Name = "KOCAELİ"
                        },
                        new
                        {
                            Id = 53,
                            CityOrder = 53,
                            Name = "KONYA"
                        },
                        new
                        {
                            Id = 54,
                            CityOrder = 54,
                            Name = "KÜTAHYA"
                        },
                        new
                        {
                            Id = 55,
                            CityOrder = 55,
                            Name = "MALATYA"
                        },
                        new
                        {
                            Id = 56,
                            CityOrder = 56,
                            Name = "MANİSA"
                        },
                        new
                        {
                            Id = 57,
                            CityOrder = 57,
                            Name = "MARDİN"
                        },
                        new
                        {
                            Id = 58,
                            CityOrder = 58,
                            Name = "MERSİN"
                        },
                        new
                        {
                            Id = 59,
                            CityOrder = 59,
                            Name = "MUĞLA"
                        },
                        new
                        {
                            Id = 60,
                            CityOrder = 60,
                            Name = "MUŞ"
                        },
                        new
                        {
                            Id = 61,
                            CityOrder = 61,
                            Name = "NEVŞEHİR"
                        },
                        new
                        {
                            Id = 62,
                            CityOrder = 62,
                            Name = "NİĞDE"
                        },
                        new
                        {
                            Id = 63,
                            CityOrder = 63,
                            Name = "ORDU"
                        },
                        new
                        {
                            Id = 64,
                            CityOrder = 64,
                            Name = "OSMANİYE"
                        },
                        new
                        {
                            Id = 65,
                            CityOrder = 65,
                            Name = "RİZE"
                        },
                        new
                        {
                            Id = 66,
                            CityOrder = 66,
                            Name = "SAKARYA"
                        },
                        new
                        {
                            Id = 67,
                            CityOrder = 67,
                            Name = "SAMSUN"
                        },
                        new
                        {
                            Id = 68,
                            CityOrder = 68,
                            Name = "SİİRT"
                        },
                        new
                        {
                            Id = 69,
                            CityOrder = 69,
                            Name = "SİNOP"
                        },
                        new
                        {
                            Id = 70,
                            CityOrder = 70,
                            Name = "SİVAS"
                        },
                        new
                        {
                            Id = 71,
                            CityOrder = 71,
                            Name = "ŞANLIURFA"
                        },
                        new
                        {
                            Id = 72,
                            CityOrder = 72,
                            Name = "ŞIRNAK"
                        },
                        new
                        {
                            Id = 5,
                            CityOrder = 73,
                            Name = "TEKİRDAĞ"
                        },
                        new
                        {
                            Id = 74,
                            CityOrder = 74,
                            Name = "TOKAT"
                        },
                        new
                        {
                            Id = 75,
                            CityOrder = 75,
                            Name = "TRABZON"
                        },
                        new
                        {
                            Id = 76,
                            CityOrder = 76,
                            Name = "TUNCELİ"
                        },
                        new
                        {
                            Id = 77,
                            CityOrder = 77,
                            Name = "UŞAK"
                        },
                        new
                        {
                            Id = 7,
                            CityOrder = 78,
                            Name = "VAN"
                        },
                        new
                        {
                            Id = 79,
                            CityOrder = 79,
                            Name = "YALOVA"
                        },
                        new
                        {
                            Id = 80,
                            CityOrder = 80,
                            Name = "YOZGAT"
                        },
                        new
                        {
                            Id = 81,
                            CityOrder = 81,
                            Name = "ZONGULDAK"
                        },
                        new
                        {
                            Id = 9,
                            CityOrder = 82,
                            Name = "Diğer"
                        });
                });

            modelBuilder.Entity("OGS.STV.SURVEY.Data.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MailSendStatus")
                        .HasColumnType("int");

                    b.Property<int?>("SurveyUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SurveyUserId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("OGS.STV.SURVEY.Data.Entities.ContractInsurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<int>("InsuranceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ContractInsurances");
                });

            modelBuilder.Entity("OGS.STV.SURVEY.Data.Entities.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InsuranceOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Insurances");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InsuranceOrder = 1,
                            Name = "Kredi Hayat Sigortaları"
                        },
                        new
                        {
                            Id = 2,
                            InsuranceOrder = 2,
                            Name = "Eğitim Sigortaları"
                        },
                        new
                        {
                            Id = 3,
                            InsuranceOrder = 3,
                            Name = "Diğer hayat sigortaları / Ferdi Kaza ürünleri"
                        },
                        new
                        {
                            Id = 4,
                            InsuranceOrder = 4,
                            Name = "Konut Sigortaları "
                        },
                        new
                        {
                            Id = 5,
                            InsuranceOrder = 5,
                            Name = "Kasko ve Trafik Sigortaları"
                        },
                        new
                        {
                            Id = 6,
                            InsuranceOrder = 6,
                            Name = "TSS (Tamamlayıcı Sağlık Sigortaları)"
                        },
                        new
                        {
                            Id = 7,
                            InsuranceOrder = 7,
                            Name = "ÖSS (Özel Sağlık Sigortaları)"
                        },
                        new
                        {
                            Id = 8,
                            InsuranceOrder = 8,
                            Name = "Seyahat Sigortaları"
                        },
                        new
                        {
                            Id = 9,
                            InsuranceOrder = 9,
                            Name = "Eşyam Sigortası"
                        },
                        new
                        {
                            Id = 10,
                            InsuranceOrder = 10,
                            Name = "KOBİ Poliçeleri"
                        },
                        new
                        {
                            Id = 11,
                            InsuranceOrder = 11,
                            Name = "YSS (Yabancılar Sağlık Sigortaları)"
                        },
                        new
                        {
                            Id = 12,
                            InsuranceOrder = 12,
                            Name = "BES (Bireysel Emeklilik)"
                        });
                });

            modelBuilder.Entity("OGS.STV.SURVEY.Data.Entities.SurveyUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCNO")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("SurveyUsers");
                });

            modelBuilder.Entity("OGS.STV.SURVEY.Data.Entities.Contract", b =>
                {
                    b.HasOne("OGS.STV.SURVEY.Data.Entities.SurveyUser", "SurveyUser")
                        .WithMany()
                        .HasForeignKey("SurveyUserId");
                });

            modelBuilder.Entity("OGS.STV.SURVEY.Data.Entities.SurveyUser", b =>
                {
                    b.HasOne("OGS.STV.SURVEY.Data.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });
#pragma warning restore 612, 618
        }
    }
}
