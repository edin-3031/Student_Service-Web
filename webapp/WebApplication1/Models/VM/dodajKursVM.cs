using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
    public class dodajKursVM
    {
        [Required]
        [StringLength(maximumLength:35, MinimumLength =5, ErrorMessage ="String length must be between 5 and 35")]
        public string Naziv { get; set; }
        [Required]
        public List<SelectListItem> studijskiProgrami { get; set; }
        [Required]
        [Range(3,7, ErrorMessage = "Must be a number between 3 and 7")]
        public int ECTS { get; set; }
        [Required]
        public float Cijena { get; set; }
        [Required]
        public int Trajanje { get; set; }
        [Required]
        [StringLength(maximumLength:15, MinimumLength =4, ErrorMessage = "String length must be between 4 and 15")]
        public string Trazenost { get; set; }
        [Required]
        public string Cilj { get; set; }
    }
}
