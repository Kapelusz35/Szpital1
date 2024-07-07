using SzpitalWWW.Data;
using SzpitalWWW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using SzpitalWWW.Data.CMS;

namespace SzpitalWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            //ViewBag.ModelStrony =await _context.Strona?.OrderBy(s=>s.Pozycja).ToListAsync();
            //ViewBag.ModelStrony =
            //      (
            //          from strona in _context.Strona
            //          orderby strona.Pozycja
            //          select strona
            //      ).ToList();
            //ViewBag.ModelAktualnosci = await _context.Aktualnosc?.OrderByDescending(a => a.Pozycja).Take(3).ToListAsync();
            //ViewBag.ModelAktualnosci =
            //    (
            //        from aktualnosc in _context.Aktualnosc
            //        orderby aktualnosc.Pozycja descending
            //        select aktualnosc
            //    ).Take(3).ToList();
            //if (id == null)
            //    id = 1;//koniecznie powinna byæ strona o id=1 w bazie
            //var item = await _context.Strona.FindAsync(id);
            return View();
        }

        //public async Task<IActionResult> Dodaj(int? id)
        //{
        //    ViewBag.ModelStrony = await _context.Strona.OrderBy(s => s.Pozycja).ToListAsync();
        //    //ViewBag.ModelStrony =
        //    //      (
        //    //          from strona in _context.Strona
        //    //          orderby strona.Pozycja
        //    //          select strona
        //    //      ).ToList();
        //    ViewBag.ModelAktualnosci = await _context.Aktualnosc.OrderByDescending(a => a.Pozycja).Take(3).ToListAsync();
        //    //ViewBag.ModelAktualnosci =
        //    //    (
        //    //        from aktualnosc in _context.Aktualnosc
        //    //        orderby aktualnosc.Pozycja descending
        //    //        select aktualnosc
        //    //    ).Take(3).ToList();
        //    if (id == null)
        //        id = 1;//koniecznie powinna byæ strona o id=1 w bazie
        //    var item = await _context.Strona.FindAsync(id);
        //    return View(item);
        //}

        public async Task<IActionResult> Kontakt()
        {
            return View();
        }


        [Authorize]
        public async Task<IActionResult> Dodaj([Bind("Id,IdRezerwacji,DestinationState,Description,phoneNumber")] Rezerwacja rezerwacja)
        {
            _context.Add(rezerwacja);
            await _context.SaveChangesAsync();
            return View();
        }

        public IActionResult OFirmie()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
