using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   SzpitalWWW.Data.Hour
{
    public class Godziny 
    {
        [Key]
        public int IdGodziny { get; set; }
        public  string NazwaLekarza { get; set; }
        public string GodzinyPracy { get; set; }
        public string pokoj { get; set; }

    }
}
