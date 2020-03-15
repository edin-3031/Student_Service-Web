using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class detaljiPolaznikPohadjaVM
    {
        public int polaznikID{get;set;}
        public List<Kurs> lista { get; set; }
    }
}
