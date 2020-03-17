using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class UplataDodajVM
    {
        [Required]
        public string Svrha { get; set; }
        [Required]
        public float Iznos { get; set; }
        [Required]
        public DateTime Datum_Uplate { get; set; }
        public string Ovjereno { get; set; }
        public int PolaznikID { get; set; }
        public int AdministracijaID { get; set; }
        public List<SelectListItem> polaznici { get; set; }
        public List<SelectListItem> administratori { get; set; }
    }
}
