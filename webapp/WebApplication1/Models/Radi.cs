using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Radi
    {
        [Key]
        public int RadiID { get; set; }

        public Akademija AkademijaId { get; set; }
        [ForeignKey("AkademijaId")]
        public int AkademijId_FK { get; set; }

        public Administracija AdministracijaId { get; set; }
        [ForeignKey("AdministracijaId")]
        public int? Administracija_FK { get; set; }

        public Profesor ProfesorId { get; set; }
        [ForeignKey("ProfesorId")]
        public int? ProfesorId_FK { get; set; }

        public int Broj_Sati_U_Sedmici { get; set; }
        public float Plata { get; set; }
        public string Vrsta_Ugovora { get; set; }
    }
}
