using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class KurseviVM
    {
        public List<Row> kursevi { get; set; }
        public class Row
        {
            public int KursID { get; set; }
            public string Naziv { get; set; }
            public int ECTS { get; set; }
            public float Cijena { get; set; }
            public int Trajanje { get; set; }
            public string Trazenost { get; set; }
            public string Cilj { get; set; }
        }
    }
}
