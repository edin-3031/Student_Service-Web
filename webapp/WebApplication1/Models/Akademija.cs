using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Akademija
    {
        [Key]
        public int AkademijaID { get; set; }
        public string Naziv { get; set; }

        public Grad Grad_FK_ID { get; set; }
        [ForeignKey("Grad_FK_ID")]
        public int GradID_FK { get; set; }

        public Drzava Drzava_FK_ID { get; set; }
        [ForeignKey("Drzava_FK_ID")]
        public int DrzavaID_FK { get; set; }

        public DateTime Izgradjeno { get; set; }
        public int Broj_Zaposlenih { get; set; }
        public int Broj_Polaznika { get; set; }
    }
}
