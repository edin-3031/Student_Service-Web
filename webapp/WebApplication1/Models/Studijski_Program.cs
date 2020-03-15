using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Studijski_Program
    {
        [Key]
        public int Studijski_programID { get; set; }

        public Akademija Akademija_ID { get; set; }
        [ForeignKey("Akademija_ID")]
        public int Akademija_ID_FK { get; set; }

        public string Naziv { get; set; }
        public int Trajanje { get; set; }
        public float Cijena { get; set; }
    }
}
