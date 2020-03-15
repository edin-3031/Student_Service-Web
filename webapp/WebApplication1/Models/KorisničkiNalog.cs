using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class KorisničkiNalog
    {
        [Key]
        public int KorisnickiNalogID { get; set; }

        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public bool Aktivan { get; set; }
    }
}
