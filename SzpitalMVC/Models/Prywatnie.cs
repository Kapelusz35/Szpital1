using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzpitalWWW.Data.Info
{
    public class Prywatnie
    {
        [Key]
        public int IdPrywatnie { get; set; } 
        public string NazwaPacjenta { get; set; }
        public string NazwaLekarza { get; set; }
        public string Godzina { get; set; }
        public double Cena { get; set; }    

    }
}
