using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class detaljiAdministracijaVM
    {
        public string Akademija { get; set; }
        public int broj_sati_u_sedmici { get; set; }
        public float plata { get; set; }
        public string vrsta_ugovora { get; set; }
        public int rad_id { get; set; }
        public int profesor_id { get; set; }
    }

    public class adminROW
    {
        public List<detaljiAdministracijaVM> row { get; set; }
    }
}
