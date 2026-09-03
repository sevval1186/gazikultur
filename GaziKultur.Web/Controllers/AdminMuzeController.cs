using System;
using System.Linq;
using System.Threading.Tasks;
using GaziKultur.Data.Concrete.EntityFramework;
using GaziKultur.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GaziKultur.Web.Controllers
{
    public class AdminMuzeController : Controller
    {
        private readonly GaziKulturContext _context;

        public AdminMuzeController(GaziKulturContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var muzeler = await _context.Muzeler
                .OrderBy(x => x.Isim)
                .ToListAsync();

            return View(muzeler);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(Muze muze)
        {
            if (!ModelState.IsValid)
            {
                return View(muze);
            }

            muze.MuzeID = Guid.NewGuid();
            muze.EklenmeTarihi = DateTime.Now;

            _context.Muzeler.Add(muze);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Guncelle(Guid id)
        {
            var muze = await _context.Muzeler
                .FirstOrDefaultAsync(x => x.MuzeID == id);

            if (muze == null)
            {
                return NotFound();
            }

            return View(muze);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Guncelle(Muze muze)
        {
            if (!ModelState.IsValid)
            {
                return View(muze);
            }

            var mevcutMuze = await _context.Muzeler
                .FirstOrDefaultAsync(x => x.MuzeID == muze.MuzeID);

            if (mevcutMuze == null)
            {
                return NotFound();
            }

            mevcutMuze.Isim = muze.Isim;
            mevcutMuze.KisaAciklama = muze.KisaAciklama;
            mevcutMuze.Tarihce = muze.Tarihce;

            mevcutMuze.Adres = muze.Adres;
            mevcutMuze.Ilce = muze.Ilce;

            mevcutMuze.ZiyaretGunleri = muze.ZiyaretGunleri;
            mevcutMuze.AcilisSaati = muze.AcilisSaati;
            mevcutMuze.KapanisSaati = muze.KapanisSaati;
            mevcutMuze.GiseKapanisSaati = muze.GiseKapanisSaati;

            mevcutMuze.GirisUcreti = muze.GirisUcreti;
            mevcutMuze.UcretTL = muze.UcretTL;
            mevcutMuze.UcretEuro = muze.UcretEuro;
            mevcutMuze.MuzekartBilgisi = muze.MuzekartBilgisi;

            mevcutMuze.Telefon = muze.Telefon;
            mevcutMuze.Eposta = muze.Eposta;

            mevcutMuze.Resim = muze.Resim;
            mevcutMuze.HaritaLinki = muze.HaritaLinki;

            mevcutMuze.Aktif = muze.Aktif;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Sil(Guid id)
        {
            var muze = await _context.Muzeler
                .FirstOrDefaultAsync(x => x.MuzeID == id);

            if (muze == null)
            {
                return NotFound();
            }

            return View(muze);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SilOnay(Guid id)
        {
            var muze = await _context.Muzeler
                .FirstOrDefaultAsync(x => x.MuzeID == id);

            if (muze == null)
            {
                return NotFound();
            }

            _context.Muzeler.Remove(muze);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}