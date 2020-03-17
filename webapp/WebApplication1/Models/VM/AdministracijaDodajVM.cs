using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class AdministracijaDodajVM
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid E-Mail address")]
        public string Mail { get; set; }
        [Required]
        public DateTime Datum_Rodjenja { get; set; }
        [Required]
        public DateTime Datum_Zaposlenja { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        [RegularExpression(@"^([(][+](387)[)]\d{2}-\d{3}-\d{3})$", ErrorMessage = "Invalid format")]
        public string Telefon { get; set; }
        [Required]
        public string Spol { get; set; }
        [Required]
        public int Staz { get; set; }
        [Required]
        public string Stalan_Zaposlenik { get; set; }
        [Required]
        public string Kancelarija { get; set; }
    }
}
