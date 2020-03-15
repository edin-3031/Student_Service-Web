using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PrikazUplata
    {
        public int? UplataID { get; internal set; }
        public string Svrha { get; internal set; }
        public float? Iznos { get; internal set; }
        public DateTime? Datum_Uplate { get; internal set; }
        public string Ovjereno { get; internal set; }
        public string Polaznik { get; internal set; }
        public string Administracija{ get; internal set; }
    }
}
