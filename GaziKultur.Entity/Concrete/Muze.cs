using System;
using GaziKultur.Core.Entities;

namespace GaziKultur.Entity.Concrete
{
    public class Muze : IEntity
    {
        public Guid MuzeID { get; set; }

        public string Isim { get; set; }
        public string KisaAciklama { get; set; }
        public string Tarihce { get; set; }

        public string Adres { get; set; }
        public string Ilce { get; set; }

        public string ZiyaretGunleri { get; set; }
        public string AcilisSaati { get; set; }
        public string KapanisSaati { get; set; }

        // Yeni ziyaret bilgisi
        public string GiseKapanisSaati { get; set; }

        // Eski alaný þimdilik koruyoruz
        public string GirisUcreti { get; set; }

        // Yeni ücret alanlarý
        public string UcretTL { get; set; }
        public string UcretEuro { get; set; }
        public string MuzekartBilgisi { get; set; }

        // Ýletiþim
        public string Telefon { get; set; }
        public string Eposta { get; set; }

        public string Resim { get; set; }
        public string HaritaLinki { get; set; }

        public bool Aktif { get; set; }

        public DateTime EklenmeTarihi { get; set; }
    }
}