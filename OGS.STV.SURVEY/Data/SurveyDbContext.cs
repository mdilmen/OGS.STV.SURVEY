using Microsoft.EntityFrameworkCore;
using OGS.STV.SURVEY.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Data
{
    public class SurveyDbContext : DbContext
    {
        public SurveyDbContext(DbContextOptions<SurveyDbContext> options) : base(options)
        {

        }
        public DbSet<City> Cities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Database.EnsureCreated();

            modelBuilder.Entity<City>()
                .HasData(
                    new City { Id = 101, CityOrder = 1, Name = "ADANA" },
                    new City { Id = 102, CityOrder = 2, Name = "ADIYAMAN" },
                    new City { Id = 103, CityOrder = 3, Name = "AFYONKARAHİSAR" },
                    new City { Id = 104, CityOrder = 4, Name = "AĞRI" },
                    new City { Id = 105, CityOrder = 5, Name = "AKSARAY" },
                    new City { Id = 106, CityOrder = 6, Name = "AMASYA" },
                    new City { Id = 2, CityOrder = 7, Name = "ANKARA" },
                    new City { Id = 4, CityOrder = 8, Name = "ANTALYA" },
                    new City { Id = 109, CityOrder = 9, Name = "ARDAHAN" },
                    new City { Id = 10, CityOrder = 10, Name = "ARTVİN" },
                    new City { Id = 11, CityOrder = 11, Name = "AYDIN" },
                    new City { Id = 12, CityOrder = 12, Name = "BALIKESİR" },
                    new City { Id = 13, CityOrder = 13, Name = "BARTIN" },
                    new City { Id = 14, CityOrder = 14, Name = "BATMAN" },
                    new City { Id = 15, CityOrder = 15, Name = "BAYBURT" },
                    new City { Id = 16, CityOrder = 16, Name = "BİLECİK" },
                    new City { Id = 17, CityOrder = 17, Name = "BİNGÖL" },
                    new City { Id = 18, CityOrder = 18, Name = "BİTLİS" },
                    new City { Id = 19, CityOrder = 19, Name = "BOLU" },
                    new City { Id = 20, CityOrder = 20, Name = "BURDUR" },
                    new City { Id = 21, CityOrder = 21, Name = "BURSA" },
                    new City { Id = 22, CityOrder = 22, Name = "ÇANAKKALE" },
                    new City { Id = 23, CityOrder = 23, Name = "ÇANKIRI" },
                    new City { Id = 24, CityOrder = 24, Name = "ÇORUM" },
                    new City { Id = 25, CityOrder = 25, Name = "DENİZLİ" },
                    new City { Id = 8, CityOrder = 26, Name = "DİYARBAKIR" },
                    new City { Id = 27, CityOrder = 27, Name = "DÜZCE" },
                    new City { Id = 28, CityOrder = 28, Name = "EDİRNE" },
                    new City { Id = 29, CityOrder = 29, Name = "ELAZIĞ" },
                    new City { Id = 30, CityOrder = 30, Name = "ERZİNCAN" },
                    new City { Id = 31, CityOrder = 31, Name = "ERZURUM" },
                    new City { Id = 32, CityOrder = 32, Name = "ESKİŞEHİR" },
                    new City { Id = 33, CityOrder = 33, Name = "GAZİANTEP" },
                    new City { Id = 34, CityOrder = 34, Name = "GİRESUN" },
                    new City { Id = 35, CityOrder = 35, Name = "GÜMÜŞHANE" },
                    new City { Id = 36, CityOrder = 36, Name = "HAKKARİ" },
                    new City { Id = 6, CityOrder = 37, Name = "HATAY" },
                    new City { Id = 38, CityOrder = 38, Name = "IĞDIR" },
                    new City { Id = 39, CityOrder = 39, Name = "ISPARTA" },
                    new City { Id = 1, CityOrder = 40, Name = "İSTANBUL" },
                    new City { Id = 3, CityOrder = 41, Name = "İZMİR" },
                    new City { Id = 42, CityOrder = 42, Name = "KAHRAMANMARAŞ" },
                    new City { Id = 43, CityOrder = 43, Name = "KARABÜK" },
                    new City { Id = 44, CityOrder = 44, Name = "KARAMAN" },
                    new City { Id = 45, CityOrder = 45, Name = "KARS" },
                    new City { Id = 46, CityOrder = 46, Name = "KASTAMONU" },
                    new City { Id = 47, CityOrder = 47, Name = "KAYSERİ" },
                    new City { Id = 48, CityOrder = 48, Name = "KIRIKKALE" },
                    new City { Id = 49, CityOrder = 49, Name = "KIRKLARELİ" },
                    new City { Id = 50, CityOrder = 50, Name = "KIRŞEHİR" },
                    new City { Id = 51, CityOrder = 51, Name = "KİLİS" },
                    new City { Id = 52, CityOrder = 52, Name = "KOCAELİ" },
                    new City { Id = 53, CityOrder = 53, Name = "KONYA" },
                    new City { Id = 54, CityOrder = 54, Name = "KÜTAHYA" },
                    new City { Id = 55, CityOrder = 55, Name = "MALATYA" },
                    new City { Id = 56, CityOrder = 56, Name = "MANİSA" },
                    new City { Id = 57, CityOrder = 57, Name = "MARDİN" },
                    new City { Id = 58, CityOrder = 58, Name = "MERSİN" },
                    new City { Id = 59, CityOrder = 59, Name = "MUĞLA" },
                    new City { Id = 60, CityOrder = 60, Name = "MUŞ" },
                    new City { Id = 61, CityOrder = 61, Name = "NEVŞEHİR" },
                    new City { Id = 62, CityOrder = 62, Name = "NİĞDE" },
                    new City { Id = 63, CityOrder = 63, Name = "ORDU" },
                    new City { Id = 64, CityOrder = 64, Name = "OSMANİYE" },
                    new City { Id = 65, CityOrder = 65, Name = "RİZE" },
                    new City { Id = 66, CityOrder = 66, Name = "SAKARYA" },
                    new City { Id = 67, CityOrder = 67, Name = "SAMSUN" },
                    new City { Id = 68, CityOrder = 68, Name = "SİİRT" },
                    new City { Id = 69, CityOrder = 69, Name = "SİNOP" },
                    new City { Id = 70, CityOrder = 70, Name = "SİVAS" },
                    new City { Id = 71, CityOrder = 71, Name = "ŞANLIURFA" },
                    new City { Id = 72, CityOrder = 72, Name = "ŞIRNAK" },
                    new City { Id = 5, CityOrder = 73, Name = "TEKİRDAĞ" },
                    new City { Id = 74, CityOrder = 74, Name = "TOKAT" },
                    new City { Id = 75, CityOrder = 75, Name = "TRABZON" },
                    new City { Id = 76, CityOrder = 76, Name = "TUNCELİ" },
                    new City { Id = 77, CityOrder = 77, Name = "UŞAK" },
                    new City { Id = 7, CityOrder = 78, Name = "VAN" },
                    new City { Id = 79, CityOrder = 79, Name = "YALOVA" },
                    new City { Id = 80, CityOrder = 80, Name = "YOZGAT" },
                    new City { Id = 81, CityOrder = 81, Name = "ZONGULDAK" },
                    new City { Id = 9, CityOrder = 82, Name = "Diğer" }

                );
        }
    }
}
