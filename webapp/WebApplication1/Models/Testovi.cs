using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Testovi
    {
        [Key]
        public int TestID { get; set; }

        public Kurs KursId { get; set; }
        [ForeignKey("KursId")]
        public int KursId_FK { get; set; }

        public int Broj_Pitanja { get; set; }
        public int Trajanje { get; set; }
        public int Maksimalan_Broj_Bodova { get; set; }

    }
}
