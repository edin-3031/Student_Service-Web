using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class DodajDetaljeRadiVM
    {
        public int radnikID { get; set; }
        public List<Akademija> akademije { get; set; }
    }
}
