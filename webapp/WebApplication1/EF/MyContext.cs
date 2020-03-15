using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.EF
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=Seminarski_rad;Trusted_Connection=False;" +
        //        "MultipleActiveResultSets=true;Integrated Security=SSPI;");
        //}


        public DbSet<Uplata> Uplata { get; set; }
        public DbSet<Polaznik> Polaznik { get; set; }
        public DbSet<Administracija> Administracija { get; set; }
        public DbSet<Drzava> Drzava { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Studijski_Program> Studijski_Program { get; set; }
        public DbSet<Kurs> Kurs { get; set; }
        public DbSet<Testovi> Testovi { get; set; }
        public DbSet<Pohadja> Pohadja { get; set; }
        public DbSet<Profesor> Profesor { get; set; }
        public DbSet<Radi> Radi { get; set; }
        public DbSet<Predaje> Predaje { get; set; }
        public DbSet<Akademija> Akademija { get; set; }
        public DbSet<KorisničkiNalog> KorisničkiNalog { get; set; }
    }
}
