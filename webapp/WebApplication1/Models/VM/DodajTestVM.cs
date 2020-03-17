using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Models.VM
{
    public class DodajTestVM
    {
        public int TestID { get; set; }
        [Required]
        public int KursID { get; set; }
        public string Kurs { get; set; }
        [Required]
        [Range(10,35, ErrorMessage = "Must be in 10-35 range")]
        public int BrojPitanja { get; set; }
        [Required]
        [Range(10,90, ErrorMessage = "Must be in 10-90 range")]
        public int Trajanje { get; set; }
        [Required]
        [Range(50,500, ErrorMessage = "Must be in 50-500 range" )]
        public float Cijena { get; set; }
        [Required]
        [Range(50,100, ErrorMessage = "Must be in 50-100 range")]
        public int MaxBrBodova { get; set; }
        public List<SelectListItem> kursevi { get; set; }
    }
}
