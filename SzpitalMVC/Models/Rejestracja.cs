﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzpitalWWW.Data.Sklep
{
    public class Rejestracja
    {
        [Key]
        public int IdTowaru { get; set; }

        [Required(ErrorMessage = "Kod towaru jest wymagany")]
        public required string Kod { get; set; }

        [Required(ErrorMessage = "Nazwa towaru jest wymagany")]
        public required string Nazwa { get; set; }

        [Required(ErrorMessage = "Cena towaru jest wymagany")]
        [Column(TypeName = "money")]
        public decimal Cena { get; set; }

        [Required(ErrorMessage = "Zdjęcie towaru jest wymagany")]
        [Display(Name = "URL zdjęcia")]
        public required string FotoURL { get; set; }

        public string Opis { get; set; } = string.Empty;

        [ForeignKey("Rodzaj")]
        public int IdRodzaju { get; set; }
        public Rodzaj? Rodzaj { get; set; }


        public string? Data { get; set; }
        public string? Miejscowosc { get; set; }
        public string? nrubez { get; set; }


    }
}
