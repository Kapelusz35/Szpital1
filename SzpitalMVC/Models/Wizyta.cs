using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzpitalWWW.Data.Home
{
    public class Wizyta
    {
        [Key]
        public int IdWizyty { get; set; }
        [Required(ErrorMessage = "Wpisz Nazwe")]
        [Display(Name = "Pozycja wyświetlania")]
		public int OfferName { get; set; }
		[Required(ErrorMessage = "Wpisz Miasto")]
		[Display(Name = "Pozycja wyświetlania")]
		public string? DestinationCity { get; set; }
		[Required(ErrorMessage = "Wpisz Stan")]
		[Display(Name = "Pozycja wyświetlania")]
		public string? DestinationState { get; set; }
		[Required(ErrorMessage = "Wpisz opis")]
		[Display(Name = "Pozycja wyświetlania")]
		public string? Description { get; set; }
		[Required(ErrorMessage = "Wpisz numer")]
		[Display(Name = "Pozycja wyświetlania")]
		public string? phoneNumber { get; set; }
	}
}
