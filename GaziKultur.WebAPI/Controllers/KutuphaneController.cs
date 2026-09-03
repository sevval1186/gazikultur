using System;
using System.Collections.Generic;
using System.Linq;
using GaziKultur.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GaziKultur.Web.Controllers
{
    public class KutuphaneController : Controller
    {
        private List<Kutuphane> KutuphaneleriGetir()
        {
            return new List<Kutuphane>
            {
                new Kutuphane
                {
                    KutuphaneID = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Isim = "Gazi Şehir Kütüphanesi",
                    KisaAciklama = "Sessiz çalışma alanları, zengin kitap koleksiyonu ve modern çalışma ortamıyla ziyaretçilerine hizmet veren bir kütüphanedir.",
                    Adres = "Gazi Mahallesi, Gaziantep",
                    Ilce = "Şehitkamil",
                    CalismaGunleri = "Pazartesi - Cumartesi",
                    AcilisSaati = "09:00",
                    KapanisSaati = "20:00",
                    InternetVarMi = true,
                    BilgisayarVarMi = true,
                    CalismaAlaniVarMi = true,
                    Resim = "",
                    HaritaLinki = "https://www.google.com/maps",
                    Aktif = true,
                    EklenmeTarihi = DateTime.Now
                },

                new Kutuphane
                {
                    KutuphaneID = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    Isim = "Gençlik Kütüphanesi",
                    KisaAciklama = "Öğrenciler ve gençler için araştırma, okuma ve bireysel çalışma alanları sunan modern bir kütüphanedir.",
                    Adres = "Merkez, Gaziantep",
                    Ilce = "Şahinbey",
                    CalismaGunleri = "Her Gün",
                    AcilisSaati = "08:30",
                    KapanisSaati = "22:00",
                    InternetVarMi = true,
                    BilgisayarVarMi = true,
                    CalismaAlaniVarMi = true,
                    Resim = "",
                    HaritaLinki = "https://www.google.com/maps",
                    Aktif = true,
                    EklenmeTarihi = DateTime.Now
                },

                new Kutuphane
                {
                    KutuphaneID = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    Isim = "Kültür Merkezi Kütüphanesi",
                    KisaAciklama = "Kitap okumak, araştırma yapmak ve ders çalışmak isteyen ziyaretçiler için hazırlanmış sakin ve kullanışlı bir kütüphanedir.",
                    Adres = "Kültür Merkezi, Gaziantep",
                    Ilce = "Şehitkamil",
                    CalismaGunleri = "Pazartesi - Pazar",
                    AcilisSaati = "10:00",
                    KapanisSaati = "21:00",
                    InternetVarMi = true,
                    BilgisayarVarMi = false,
                    CalismaAlaniVarMi = true,
                    Resim = "",
                    HaritaLinki = "https://www.google.com/maps",
                    Aktif = true,
                    EklenmeTarihi = DateTime.Now
                }
            };
        }

        public IActionResult Index()
        {
            var kutuphaneler = KutuphaneleriGetir();
            return View(kutuphaneler);
        }

        public IActionResult Detay(Guid id)
        {
            var kutuphane = KutuphaneleriGetir()
                .FirstOrDefault(x => x.KutuphaneID == id);

            if (kutuphane == null)
            {
                return NotFound();
            }

            return View(kutuphane);
        }
    }
}s