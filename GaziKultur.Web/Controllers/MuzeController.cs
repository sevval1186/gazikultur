using GaziKultur.Data.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GaziKultur.Web.Controllers
{
    public class MuzeController : Controller
    {
        private readonly GaziKulturContext _context;

        public MuzeController(GaziKulturContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var muzeler = await _context.Muzeler
                .Where(x => x.Aktif)
                .OrderBy(x => x.Isim)
                .ToListAsync();

            return View(muzeler);
        }

        public async Task<IActionResult> Detay(Guid id)
        {
            var muze = await _context.Muzeler
                .FirstOrDefaultAsync(x => x.MuzeID == id && x.Aktif);

            if (muze == null)
            {
                return NotFound();
            }

            return View(muze);
        }
    }
}