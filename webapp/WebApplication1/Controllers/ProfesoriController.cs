using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.EF;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProfesoriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly MyContext db;

        public ProfesoriController(MyContext _db)
        {
            db = _db;
        }

        public ActionResult Prikaz()
        {
            List<PrikazProfesora> podaci = db.Profesor.Select(x => new PrikazProfesora
            {
                adresa=x.Adresa,
                datum_rodjenja=x.Datum_Rodjenja,
                datum_zaposlenja=x.Datum_Zaposlenja,
                ime=x.Ime,
                kancelarija=x.Kancelarija,
                mail=x.Mail,
                prezime=x.Prezime,
                Profesor_Id=x.ProfesorID,
                spol=x.Spol,
                stalan_zaposlenik=x.Stalan_Zaposlenik,
                staz=x.Staz,
                telefon=x.Telefon,
                zvanje=x.Zvanje
            }).ToList();

            ViewData["profesor"] = podaci;

            return View();
        }
        public ActionResult Ukloni(int trazeni)
        {
            Profesor temp = db.Profesor.Where(x => x.ProfesorID == trazeni).SingleOrDefault();

            if (temp == null)
                return View("Error");
            try
            {
                db.Remove(temp);
                db.SaveChanges();
            }
            catch (Exception)
            {
                TempData["greska"] = "PRVO UKLONITE DETALJE O RADU";
                return RedirectToAction("Prikaz", "Profesori");
            }

            TempData["uspjeh"] = "USPJEŠNO STE UKLONULI";
            return RedirectToAction("Prikaz","Profesori");
            //return Redirect("Prikaz");
        }
        public IActionResult DodajForm()
        {
            return View();
        }

        public IActionResult Dodaj(string ime, string prezime, string zvanje, string mail, DateTime datum_rodjenja, DateTime datum_zaposlenja, string adresa, string telefon, string spol, int staz, string stalan_zaposlenik, string kancelarija)
        {
            Profesor temp = new Profesor
            {
                Adresa = adresa,
                Datum_Rodjenja = datum_rodjenja,
                Datum_Zaposlenja = datum_zaposlenja,
                Ime = ime,
                Kancelarija = kancelarija,
                Mail = mail,
                Prezime = prezime,
                Spol = spol,
                Stalan_Zaposlenik = stalan_zaposlenik,
                Staz = staz,
                Telefon = telefon,
                Zvanje = zvanje,
                KorisničkiNalog_ID_FK=1
            };

            if (temp == null)
                return View("Error");

            db.Add(temp);
            db.SaveChanges();

            TempData["uspjeh"] = "USPJEŠNO STE DODALI";

            return Redirect("Prikaz");
        }

        public IActionResult UrediForm(int id)
        {
            ViewData["uredi"] = db.Profesor.Where(x => x.ProfesorID == id).SingleOrDefault();

            return View();
        }

        public IActionResult Uredi(int id, string ime, string prezime, string zvanje, string mail, DateTime datum_rodjenja, DateTime datum_zaposlenja, string adresa, string telefon, string spol, int staz, string stalan_zaposlenik, string kancelarija)
        {
            Profesor tmp = db.Profesor.Where(x => x.ProfesorID == id).SingleOrDefault();

            tmp.Adresa = adresa;
            tmp.Datum_Rodjenja = datum_rodjenja;
            tmp.Datum_Zaposlenja = datum_zaposlenja;
            tmp.Ime = ime;
            tmp.Prezime = prezime;
            tmp.ProfesorID = id;
            tmp.Spol = spol;
            tmp.Stalan_Zaposlenik = stalan_zaposlenik;
            tmp.Staz = staz;
            tmp.Telefon = telefon;
            tmp.Zvanje = zvanje;
            tmp.Mail = mail;
            tmp.Kancelarija = kancelarija;

            db.SaveChanges();

            TempData["uspjeh"] = "USPJEŠNO STE UREDILI";
            return Redirect("/Profesori/Prikaz");
        }
    }
}