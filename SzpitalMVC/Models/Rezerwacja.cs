using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzpitalWWW.Data.CMS
{
    public class Rezerwacja
    {
        [Key]
        public int IdRezerwacji { get; set; }


        public string? DestinationCity { get; set; }

        public string? DestinationState { get; set; }

        public string? Description { get; set; }

        public string? phoneNumber { get; set; }
    }
}

