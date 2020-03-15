using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Kurs
    {
        [Key]
        public int KursID { get; set; }

        public Studijski_Program Studijski_Program_ID { get; set; }
        [ForeignKey("Studijski_Program_ID")]
        public int Studijski_Program_ID_FK { get; set; }

        public string Naziv { get; set; }
        public int ECTS { get; set; }
        public float Cijena { get; set; }
        public int Trajanje { get; set; }
        public string Trazenost { get; set; }
        public string Cilj { get; set; }
    }
}
