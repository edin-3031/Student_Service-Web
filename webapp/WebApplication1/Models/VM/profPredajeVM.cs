using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class profPredajeVM
    {
        public string kurs { get; set; }
        public DateTime datum_predavanja{ get; set; }
        public string odrzano { get; set; }
        public string vrsta { get; set; }
        public string opis { get; set; }
        public int predaje_id { get; set; }
    }

    public class RowProfPredajeVM
    {
        public List<profPredajeVM> row { get; set; }
    }
}
