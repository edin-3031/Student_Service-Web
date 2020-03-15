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
    public class TestoviController : Controller
    {
        private readonly MyContext db;

        public TestoviController(MyContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Prikaz()
        {
            List<TestoviPrikazVM> temp = db.Testovi.Include(a => a.KursId).Select(x => new TestoviPrikazVM
            {
                broj_pitanja=x.Broj_Pitanja,
                kurs=x.KursId.Naziv,
                kursId=x.KursId.KursID,
                max_bodova=x.Maksimalan_Broj_Bodova,
                testId=x.TestID,
                trajanje=x.Trajanje
            }).ToList();

            podaciTestPrikazVM model = new podaciTestPrikazVM
            {
                row = temp
            };

            return View(model);
        }

        public IActionResult Brisi(int id)
        {
            Testovi tmp = db.Testovi.Where(a => a.TestID == id).SingleOrDefault();

            if (tmp == null)
                return View("Error");

            db.Remove(tmp);
            db.SaveChanges();

            TempData["uspjesno"] = "USPJEŠNO STE UKLONULI";

            return Redirect("Prikaz");
        }

        public IActionResult DodajForm()
        {
            TestoviDodavanjeVM model = new TestoviDodavanjeVM
            {
                kursevi = db.Kurs.ToList()                
            };

            return View(model);
        }

        public IActionResult Dodaj(int kursId, int brojPitanja, int trajanje, int bodovi)
        {
            Testovi tmp = new Testovi
            {
                Broj_Pitanja = brojPitanja,
                KursId_FK = kursId,
                Maksimalan_Broj_Bodova = bodovi,
                Trajanje = trajanje
            };

            db.Add(tmp);
            db.SaveChanges();

            TempData["uspjesno"] = "USPJEŠNO STE DODALI";

            return Redirect("Prikaz");
        }

        public IActionResult UrediForm(int id)
        {
            Testovi tmp = db.Testovi.Where(x => x.TestID == id).SingleOrDefault();

            ViewData["Uredi"] = tmp;

            string nazivKursa = db.Testovi.Where(x => x.TestID == id).Select(y => y.KursId.Naziv).Single();
            int idKursa = db.Testovi.Where(x => x.TestID == id).Select(y => y.KursId.KursID).Single();

            ViewData["naziv"] = nazivKursa;
            ViewData["id"] = idKursa;

            return View();
        }

        public IActionResult Uredi(int id, int kursId, int brojPitanja, int trajanje, int bodovi)
        {
            Testovi tmp = db.Testovi.Where(x => x.TestID == id).Single();

            tmp.Broj_Pitanja = brojPitanja;
            tmp.Maksimalan_Broj_Bodova = bodovi;
            tmp.Trajanje = trajanje;

            db.SaveChanges();

            TempData["uspjesno"] = "USPJEŠNO STE UREDILI";

            return Redirect("/Testovi/Prikaz");
        }
    }
}