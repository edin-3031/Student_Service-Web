using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class TestoviVM
    {
        public List<Row> testovi { get; set; }
        public class Row
        {
            public int TestID { get; set; }
            public int KursID { get; set; }
            public string NazivKursa { get; set; }
            public int BrojPitanja { get; set; }
            public int Trajanje { get; set; }
            public int MaxBodovi { get; set; }
        }
    }
}
