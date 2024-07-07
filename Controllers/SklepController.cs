using Firma.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firma.PortalWWW.Controllers
{
    public class SklepController : Controller
    {
        private readonly ApplicationDBContext _context;
        public SklepController(ApplicationDBContext context)
        {
            _context = context;
        }
        //widok Index w towarach wysietla wszystkie towary danego rodzaju
        //parametrem funkcji jest id rodzaju, którego towary mam wyswietlac
        public async Task<IActionResult> Index(int? id)
        {
            ViewBag.ModelStrony = await _context.Strona.OrderBy(s => s.Pozycja).ToListAsync();
            //ten ViewBag be....
            ViewBag.Rodzaje = await _context.Rodzaj.ToListAsync();
            if(id == null)
            {
                id = 1;//to zmienimy, bo domyslenie beda towary promowane
            }
            //do zmiennej items laduje ....
            var items=await _context.Towar.Where(t=>t.IdRodzaju==id).ToListAsync(); 
            //do widoku przekazuje towary danego rodzaju
            return View(items);
        }
    }
}
