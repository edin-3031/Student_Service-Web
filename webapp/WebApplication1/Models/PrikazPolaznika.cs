using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PrikazPolaznika
    {
        public int Polaznik_Id { get; internal set; }

        public string ime { get; set; }
        public string prezime { get; set; }
        public string broj_dosijea { get; set; }
        public DateTime datum_rodjenja { get; set; }
        public string mail { get; set; }
        public string telefon { get; set; }
        public string adresa { get; set; }
        public string spol { get; set; }
        public string status { get; set; }
        public string nacin_studiranja { get; set; }
        public int? upisan_semestar { get; set; }
        public int? ovjeren_semestar { get; set; }
        public int godina_studija { get; set; }
        public string obnavlja_godinu { get; set; }
        public float prosjecna_ocjena { get; set; } 
    }
}
