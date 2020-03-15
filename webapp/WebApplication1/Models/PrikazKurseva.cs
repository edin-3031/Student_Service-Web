using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PrikazKurseva
    {
        public int KursID { get; internal set; }
        public string Naziv { get; internal set; }
        public string Studijski_program { get; internal set; }
        public int ECTS { get; internal set; }
        public float Cijena { get; internal set; }
        public int Trajanje { get; internal set; }
        public string Trazenost { get; internal set; }
        public string Cilj { get; internal set; }
        public int SP_id { get; set; }
    }
}
