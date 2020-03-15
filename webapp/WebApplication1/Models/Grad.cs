using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Grad
    {
        [Key]
        public int GradID { get; set; }

        public Drzava Drzava_ID { get; set; }
        [ForeignKey("Drzava_ID")]
        public int Drzava_ID_FK { get; set; }

        public string Naziv { get; set; }
        public string Skracenica { get; set; }
        public string Postanski_Broj { get; set; }
    }
}
