using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzpitalWWW.Data.History
{
    public class Platnosci
    {
        [Key]
        public int IdPlatnosci{ get; set; }
        public  string TytulPlatnosci { get; set; }
        public  string imieNazw { get; set; }
        public  string Data { get; set; }
        public string Usluga { get; set; }
    }
}
