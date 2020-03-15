using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Pohadja
    {
        [Key]
        public int PohadjaID { get; set; }

        public Kurs Kurs_FK_ID { get; set; }
        [ForeignKey("Kurs_FK_ID")]
        public int KursID_FK { get; set; }

        public Polaznik Polaznik_FK_ID { get; set; }
        [ForeignKey("Polaznik_FK_ID")]
        public int PolaznikID_FK { get; set; }

        public DateTime Pocetak { get; set; }
        public DateTime Kraj { get; set; }
        public string Obnavlja { get; set; }
        public int Broj_Obnavljanja { get; set; }
    }
}
