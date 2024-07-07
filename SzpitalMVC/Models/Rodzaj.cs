﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzpitalWWW.Data.Sklep
{
    public class Rodzaj
    {
        [Key]
        public int IdRodzaju { get; set; }

        [Required(ErrorMessage = "Nazwa rodzaju jest wymagana")]
        [MaxLength(30, ErrorMessage = "Nazwa kategorii powinna mieć max 30 znakow")]
        public required string Nazwa { get; set; }
        public string Opis { get; set; } = string.Empty;
        public ICollection<Towar> Towar { get; } = new List<Towar>();
    }
}