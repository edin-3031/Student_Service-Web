using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class PolaznikDodajVM
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
        public string Adresa { get; set; }
        [Required]
        [RegularExpression(@"^([(][+](387)[)]\d{2}-\d{3}-\d{3})$", ErrorMessage ="Invalid format")]
        public string Telefon { get; set; }
        [Required]
        public string Spol { get; set; }
        [Required]
        [RegularExpression(@"^(IB1\d{5}|ib1\d{5}|iB1\d{5}|Ib1\d{5})$", ErrorMessage ="Invalid format")]
        public string Broj_Dosijea { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Nacin_Studiranja { get; set; }
        [Required]
        public int Upisan_Semestar { get; set; }
        [Required]
        public int Ovjeren_Semestar { get; set; }
        [Required]
        public int Godina_Upisa { get; set; }
        [Required]
        public int Godina_Studija { get; set; }
        [Required]
        public string Obnavlja_Godinu { get; set; }
        [Required]
        public float Prosjecna_Ocjena { get; set; }
    }
}
