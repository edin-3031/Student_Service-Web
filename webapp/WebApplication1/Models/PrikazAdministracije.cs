using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PrikazAdministracije
    {
        public int administracija_Id { get; internal set; }
        public string ime { get; internal set; }
        public string prezime { get; internal set; }
        public string mail { get; internal set; }
        public DateTime datum_rodjenja { get; internal set; }
        public DateTime datum_zaposlenja { get; internal set; }
        public string adresa { get; internal set; }
        public string telefon { get; internal set; }
        public string spol { get; internal set; }
        public int staz { get; internal set; }
        public string stalan_zapolsenik { get; internal set; }
        public string kancelarija { get; internal set; }
    }
}