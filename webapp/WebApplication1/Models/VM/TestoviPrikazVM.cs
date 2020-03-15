using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class TestoviPrikazVM
    {
        public int testId { get; internal set; }
        public int kursId { get; internal set; }
        public string kurs { get; internal set; }
        public int broj_pitanja { get; internal set; }
        public int trajanje { get; internal set; }
        public int max_bodova { get; internal set; }
    }
    public class podaciTestPrikazVM
    {
        public List<TestoviPrikazVM> row;
    }
}
