using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Administracija
    {
        [Key]
        public int AdministracijaID { get; set; }

        public KorisničkiNalog KorisničkiNalog_ID { get; set; }
        [ForeignKey("KorisničkiNalog_ID")]
        public int KorisničkiNalog_ID_FK { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public DateTime Datum_Rodjenja { get; set; }
        public DateTime Datum_Zaposlenja { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Spol { get; set; }
        public int Staz { get; set; }
        public string Stalan_Zapolsenik { get; set; }
        public string Kancelarija { get; set; }
    }
}
