using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class detaljiPolaznikVM
    {
        public int pohadjaID { get; set; }
        public string kurs { get; set; }
        public DateTime pocetak { get; set; }
        public DateTime kraj { get; set; }
        public string Obnavlja { get; set; }
        public int Broj_Obnavljanja { get; set; }
    }

    public class row
    {
        public List<detaljiPolaznikVM> rows { get; set; }
    }
}
