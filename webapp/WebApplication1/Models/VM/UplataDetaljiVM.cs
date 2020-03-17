using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class UplataDetaljiVM
    {
        public string Svrha { get; set; }
        public float Iznos { get; set; }
        public DateTime Datum_uplate { get; set; }
        public string Ovjereno { get; set; }
        public string Polaznik { get; set; }
        public string Administracija { get; set; }
    }
}
