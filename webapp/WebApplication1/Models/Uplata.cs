using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Uplata
    {
        [Key]
        public int UplataID { get; set; }

        public string Svrha { get; set; }
        public float Iznos { get; set; }
        public DateTime Datum_uplate { get; set; }
        public string Ovjereno { get; set; }

        public Polaznik Polaznik_ID { get; set; }
        [ForeignKey("Polaznik_ID")]
        public int Polaznik_ID_FK { get; set; }

        public Administracija Administracija_ID { get; set; }
        [ForeignKey("Administracija_ID")]
        public int Administracija_ID_FK { get; set; }
    }
}
