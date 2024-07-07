using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzpitalWWW.Data.CMS;
using SzpitalWWW.Data.Sklep;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SzpitalWWW.Data.Home;
namespace SzpitalWWW.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Aktualnosc> Aktualnosc { get; set; } = default!;
        public DbSet<Strona> Strona { get; set; } = default!;
        public DbSet<Rodzaj> Rodzaj { get; set; } = default!;
        public DbSet<Towar> Towar { get; set; } = default!;

        public DbSet<Wizyta> Wizyta { get; set; }

        public DbSet<Rezerwacja> rezerwacjas { get; set; }

    }
}

