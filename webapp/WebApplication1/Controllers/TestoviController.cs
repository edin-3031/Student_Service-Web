using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult Testovi()
        {
            TestoviVM vm = new TestoviVM
            {
                testovi=db.Testovi.Include(x=>x.KursId)
                .Select(x=>new TestoviVM.Row
                {
                    KursID=x.KursId_FK,
                    BrojPitanja=x.Broj_Pitanja,
                    MaxBodovi=x.Maksimalan_Broj_Bodova,
                    NazivKursa=x.KursId.Naziv,
                    TestID=x.TestID,
                    Trajanje=x.Trajanje
                }).ToList()
            };
            return View(vm);
        }

        public IActionResult Dodaj()
        {
            DodajTestVM vm = new DodajTestVM
            {
                kursevi=db.Kurs
                .Select(x=>new SelectListItem
                {
                    Value=x.KursID.ToString(),
                    Text=x.Naziv
                }).ToList()
            };
            return View(vm);
        }
        public IActionResult Snimi(int KursID, int BrojPitanja, int Trajanje, int MaxBrBodova)
        {
            Kurs k = db.Kurs.Find(KursID);
            Testovi t = new Testovi
            {
                KursId = k,
                KursId_FK = KursID,
                Broj_Pitanja = BrojPitanja,
                Maksimalan_Broj_Bodova = MaxBrBodova,
                Trajanje = Trajanje
            };
            try
            {
                db.Testovi.Update(t);
                db.SaveChanges();
                TempData["uspjesno"] = "Uspješno ste dodali novi test!";
            }
            catch (Exception)
            {
                TempData["greska"] = "GREŠKA PRILIKOM DODAVANJA TESTA";
                return Redirect("/Testovi/Testovi");
            }
            return Redirect("/Testovi/Testovi");
        }
        public IActionResult Ukloni(int TestID)
        {
            Testovi t = db.Testovi.Find(TestID);
            try
            {
                db.Testovi.Remove(t);
                db.SaveChanges();
                TempData["uspjesno"] = "Uspješno ste uklonuli test";
            }
            catch (Exception)
            {
                TempData["greska"] = "Greška prilikom uklanjanja testa";
                return Redirect("/Testovi/Testovi");
            }
            return Redirect("/Testovi/Testovi");
        }
        public IActionResult UrediTest(int TestID)
        {
            Testovi t = db.Testovi.Find(TestID);
            Kurs k = db.Kurs.Find(t.KursId_FK);
            UrediTestVM vm = new UrediTestVM
            {
                KursID=t.KursId_FK,
                Kurs=k.Naziv,
                BrojPitanja=t.Broj_Pitanja,
                MaxBrBodova=t.Maksimalan_Broj_Bodova,
                Trajanje=t.Trajanje,
                TestID=TestID,
                kursevi=db.Kurs
                .Select(x=>new SelectListItem
                {
                    Value=x.KursID.ToString(),
                    Text=k.Naziv
                }).ToList()
            };
            return View(vm);
        }
        public IActionResult SnimiIzmjene(int TestID, int KursID, int Trajanje, int BrojPitanja, int MaxBrBodova)
        {
            Testovi t = db.Testovi.Find(TestID);
            Kurs k = db.Kurs.Find(KursID);
            t.KursId_FK = KursID;
            t.Maksimalan_Broj_Bodova = MaxBrBodova;
            t.Trajanje = Trajanje;
            t.Broj_Pitanja = BrojPitanja;
            t.KursId = k;
            try
            {
                db.Testovi.Update(t);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return Redirect("/Testovi/Testovi");
            }
            return Redirect("/Testovi/Testovi");
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

        //public IActionResult Dodaj(int kursId, int brojPitanja, int trajanje, int bodovi)
        //{
        //    Testovi tmp = new Testovi
        //    {
        //        Broj_Pitanja = brojPitanja,
        //        KursId_FK = kursId,
        //        Maksimalan_Broj_Bodova = bodovi,
        //        Trajanje = trajanje
        //    };

        //    db.Add(tmp);
        //    db.SaveChanges();

        //    TempData["uspjesno"] = "USPJEŠNO STE DODALI";

        //    return Redirect("Prikaz");
        //}

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