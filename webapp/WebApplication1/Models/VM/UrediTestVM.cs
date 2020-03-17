using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class UrediTestVM
    {
        public int KursID { get; set; }
        public string Kurs { get; set; }
        public int TestID { get; set; }
        public int BrojPitanja { get; set; }
        public int Trajanje { get; set; }
        public int MaxBrBodova { get; set; }
        public List<SelectListItem> kursevi { get; set; }
    }
}
