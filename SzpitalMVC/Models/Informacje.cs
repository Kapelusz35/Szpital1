using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzpitalWWW.Data.Information
{
    public class Informacje
    {
        [Key]
        public int IdInformacji { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
