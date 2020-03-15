using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Predaje
    {
        [Key]
        public int PredajeID { get; set; }

        public Profesor ProfesorId { get; set; }
        [ForeignKey("ProfesorId")]
        public int ProfesorId_FK { get; set; }

        public Kurs KursId { get; set; }
        [ForeignKey("KursId")]
        public int KursId_FK { get; set; }

        public DateTime Datum_Predavanja { get; set; }
        public string Odrzano { get; set; }
        public string Vrsta { get; set; }
        public string Opis { get; set; }

    }
}
