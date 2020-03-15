using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Polaznik
    {
        [Key]
        public int PolaznikID { get; set; }

        public KorisničkiNalog KorisničkiNalog_ID { get; set; }
        [ForeignKey("KorisničkiNalog_ID")]
        public int KorisničkiNalog_ID_FK { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public DateTime Datum_Rodjenja { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Spol { get; set; }
        public string Broj_Dosijea { get; set; }
        public string Status { get; set; }
        public string Nacin_Studiranja { get; set; }
        public int Upisan_Semestar { get; set; }
        public int Ovjeren_Semestar { get; set; }
        public int Godina_Upisa { get; set; }
        public int Godina_Studija { get; set; }
        public string Obnavlja_Godinu { get; set; }
        public float Prosjecna_Ocjena { get; set; }

    }
}
