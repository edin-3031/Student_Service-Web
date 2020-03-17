using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using WebApplication1.EF;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Controllers
{
    public class KurseviController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly MyContext db;

        public KurseviController(MyContext _db)
        {
            db = _db;
        }



        //public IActionResult Uredi(int id, int studijskiProgram, string naziv, int ects, float cijena, int trajanje, string trazenost, string cilj)
        //{
        //    Kurs tmp = db.Kurs.Where(x => x.KursID == id).Single();

        //    tmp.Naziv = naziv;
        //    tmp.Studijski_Program_ID_FK = studijskiProgram;
        //    tmp.Trajanje = trajanje;
        //    tmp.Trazenost = trazenost;
        //    tmp.Cijena = cijena;
        //    tmp.Cilj = cilj;
        //    tmp.ECTS = ects;

        //    db.SaveChanges();

        //    TempData["uspjesno"] = "USPJEŠNO STE UREDILI";

        //    return Redirect("/Kursevi/PrikaziKurseve");
        //}
        public IActionResult DodajKurs()
        {
            dodajKursVM vm = new dodajKursVM
            {
                studijskiProgrami = db.Studijski_Program
                .Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = x.Studijski_programID.ToString(),
                    Text = x.Naziv
                }).ToList()
            };
           
            return View(vm);
        }

        [HttpPost]
        public IActionResult SnimiKurs(string Naziv, int StudijskiProgramID, int Trajanje, int ECTS, float Cijena, string Trazenost, string Cilj)
        {
            Studijski_Program sp = db.Studijski_Program.Where(x => x.Studijski_programID == StudijskiProgramID).FirstOrDefault();
            Kurs k = new Kurs
            {
                Naziv = Naziv,
                Studijski_Program_ID_FK = StudijskiProgramID,
                ECTS = ECTS,
                Trazenost=Trazenost,
                Cijena=Cijena,
                Cilj=Cilj,
                Studijski_Program_ID=sp,
                Trajanje=Trajanje
            };
            if (ModelState.IsValid)
            {
                try
                {
                    db.Kurs.Add(k);
                    db.SaveChanges();
                    TempData["uspjesno"] = "Uspješno ste dodali novi kurs!";
                }
                catch (Exception)
                {
                    TempData["greska"] = "GRESKA PRILIKOM DODAVANJA";
                }
            }else
            {
                return NotFound($"Error");
            }
            return Redirect("Kursevi");
        }
        public IActionResult Kursevi()
        {
            KurseviVM vm = new KurseviVM
            {
                kursevi = db.Kurs
                .Select(x => new KurseviVM.Row
                {
                    KursID = x.KursID,
                    ECTS = x.ECTS,
                    Cijena = x.Cijena,
                    Cilj = x.Cilj,
                    Naziv = x.Naziv,
                    Trajanje = x.Trajanje,
                    Trazenost = x.Trazenost
                }).ToList()
            };
            return View(vm);
        }
        public IActionResult UrediKurs(int KursID)
        {
            Kurs k = db.Kurs.Where(x => x.KursID == KursID).FirstOrDefault();
            if (k == null)
            {
                return NotFound($"Kurs nije pronadjen"); 
            }
            Studijski_Program sp = db.Studijski_Program.Where(x => x.Studijski_programID == k.Studijski_Program_ID_FK).FirstOrDefault();
            UrediKursVM vm = new UrediKursVM
            {
                KursID = KursID,
                Naziv = k.Naziv,
                ECTS = k.ECTS,
                Cijena = k.Cijena,
                Trajanje = k.Trajanje,
                Trazenost = k.Trazenost,
                Cilj = k.Cilj,
                StudijskiProgram=sp.Naziv,
                StudijskiProgramID=sp.Studijski_programID
            };
            return View(vm);
        }
        public IActionResult SnimiUpdate(int KursID, string Naziv,int Trajanje, int ECTS, int StudijskiProgramID, string Trazenost, string Cilj, float Cijena)
        {
            Kurs k = db.Kurs.Where(x => x.KursID == KursID).Include(x => x.Studijski_Program_ID).FirstOrDefault();
            k.Naziv = Naziv;
            k.Trajanje = Trajanje;
            k.Trazenost = Trazenost;
            k.Cijena = Cijena;
            k.Cilj = Cilj;
            k.ECTS = ECTS;
            db.Kurs.Update(k);
            db.SaveChanges();
            return Redirect("/Kursevi/Kursevi");
        }
        public IActionResult DeleteKurs(int KursID)
        {
            Kurs k = db.Kurs.Find(KursID);
            
                try
                {
                    db.Kurs.Remove(k);
                    db.SaveChanges();
                    TempData["uspjesno"] = "USPJEŠNO STE UKLONULI";
                    return Redirect("/Kursevi/Kursevi");
                }
                catch (Exception)
                {
                    TempData["greska"] = "GRESKA";
                    return Redirect("/Kursevi/Kursevi");
                }
        }
    }
}