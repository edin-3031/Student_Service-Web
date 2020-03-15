using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.EF;
using WebApplication1.Models;

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

        public ActionResult DodajKurs(int studijskiProgram,string naziv, int ects, float cijena, int trajanje, string trazenost, string cilj)
        {

            Kurs temp = new Kurs()
            {
                Studijski_Program_ID_FK = studijskiProgram,
                Naziv = naziv,
                ECTS = ects,
                Cijena = cijena,
                Trajanje = trajanje,
                Trazenost = trazenost,
                Cilj = cilj
            };

            if (temp == null)
                return View("Error");

            db.Add(temp);
            db.SaveChanges();

            TempData["uspjesno"] = "USPJEŠNO STE DODALI";

            return Redirect("PrikaziKurseve");
        }

        public ActionResult DodajKursForm()
        {

            List<Kurs> podaci = db.Kurs.ToList();
            ViewData["kurs_id"] = podaci;

            List<Studijski_Program> podaci2 = db.Studijski_Program.ToList();
            ViewData["SP_id"] = podaci2;

            return View("ViewKurseveForm");
        }

        public IActionResult PrikaziKurseve()
        {

            List<PrikazKurseva> podaci = db.Kurs.Select(x => new PrikazKurseva
            {
                KursID=x.KursID,
                Naziv=x.Naziv,
                Studijski_program = x.Studijski_Program_ID.Naziv,
                ECTS = x.ECTS,
                Cijena = x.Cijena,
                Trajanje = x.Trajanje,
                Trazenost = x.Trazenost,
                Cilj = x.Cilj,
                SP_id=x.Studijski_Program_ID.Studijski_programID
            }).ToList();

            ViewData["kurs_id"] = podaci;

            return View("ViewKurseve");
        }

        public ActionResult UkoniKurs(int TrazeniKurs)
        {
            Kurs temp = db.Kurs.Where(x => x.KursID == TrazeniKurs).SingleOrDefault();

            if (temp == null)
                return View("Error");
            try
            {
                db.Remove(temp);
                db.SaveChanges();

                TempData["uspjesno"] = "USPJEŠNO STE UKLONULI";
                return Redirect("/Kursevi/PrikaziKurseve");
            }
            catch (Exception)
            {
                TempData["greska"] = "PRVO UKLONITE KURS IZ DETALJA PROFESORA, POLAZNIKA I TESTA";
                return Redirect("/Kursevi/PrikaziKurseve");
            }
        }

        public IActionResult UrediForm(int id)
        {
            Kurs tmp = db.Kurs.Where(x => x.KursID == id).SingleOrDefault();

            string nazivSP = db.Kurs.Where(x => x.KursID == id).Select(y => y.Studijski_Program_ID.Naziv).Single();

            ViewData["uredi"] = tmp;
            ViewData["naziv"] = nazivSP;

            return View();
        }

        public IActionResult Uredi(int id, int studijskiProgram, string naziv, int ects, float cijena, int trajanje, string trazenost, string cilj)
        {
            Kurs tmp = db.Kurs.Where(x => x.KursID == id).Single();

            tmp.Naziv = naziv;
            tmp.Studijski_Program_ID_FK = studijskiProgram;
            tmp.Trajanje = trajanje;
            tmp.Trazenost = trazenost;
            tmp.Cijena = cijena;
            tmp.Cilj = cilj;
            tmp.ECTS = ects;

            db.SaveChanges();

            TempData["uspjesno"] = "USPJEŠNO STE UREDILI";

            return Redirect("/Kursevi/PrikaziKurseve");
        }
    }
}