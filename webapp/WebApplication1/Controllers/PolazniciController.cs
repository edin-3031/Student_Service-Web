using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.EF;
using WebApplication1.Helper;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    public class PolazniciController : Controller
    {
        private readonly MyContext db;
        private readonly IEmailSender _emailSender;
        private readonly IHttpContextAccessor _httpCA;
        public PolazniciController(MyContext _db, IEmailSender emailSender, IHttpContextAccessor httpContextAccessor)
        {
            db = _db;
            _emailSender = emailSender;
            _httpCA = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }


        public ActionResult Prikaz()
        {
            List<PrikazPolaznika> podaci = db.Polaznik.Select(x=>new PrikazPolaznika
            {
                adresa=x.Adresa,
                broj_dosijea=x.Broj_Dosijea,
                datum_rodjenja=x.Datum_Rodjenja,
                godina_studija=x.Godina_Studija,
                ime=x.Ime,  
                prezime=x.Prezime,
                mail=x.Mail,
                nacin_studiranja=x.Nacin_Studiranja,
                obnavlja_godinu=x.Obnavlja_Godinu,
                ovjeren_semestar=x.Ovjeren_Semestar,
                Polaznik_Id=x.PolaznikID,
                spol=x.Spol,
                status=x.Status,
                telefon=x.Telefon,
                upisan_semestar=x.Upisan_Semestar,
                prosjecna_ocjena=x.Prosjecna_Ocjena
            }).ToList();

            ViewData["Student"] = podaci;
            return View();
        }

        public ActionResult Ukloni(int trazeni)
        {
            if (trazeni < 0)
                throw new Exception("Unesen je negativni broj za ID!");

            Polaznik temp = db.Polaznik.Where(x => x.PolaznikID == trazeni).SingleOrDefault();

            if (temp == null)
                return View("Error");
            try
            {
                db.Remove(temp);
                db.SaveChanges();

                TempData["uspjesno"] = "USPJEŠNO STE UKLONULI";
                return Redirect("Prikaz");
            }
            catch (Exception)
            {
                TempData["greska"] = "PRVO UKLONITE DETALJE";
                return Redirect("Prikaz");
            }
        }

        public IActionResult DodajForm()
        {
            return View();
        }

        public async  Task<IActionResult> Dodaj(string ime, string prezime, string mail, DateTime datum_rodjenja, string adresa, string telefon, string spol, string broj_dosijea, string status, string nacin_studiranja, int upisan_semestar, int ovjeren_semestar, int godina_upisa, int godina_studija, string obnavlja_godinu, float prosjecna_ocjena)
        {
            Random rand = new Random();

            Polaznik temp = new Polaznik
            {
                Adresa = adresa,
                Broj_Dosijea = broj_dosijea,
                Datum_Rodjenja = datum_rodjenja,
                Godina_Studija = godina_studija,
                Godina_Upisa = godina_upisa,
                Ime = ime,
                Mail = mail,
                Nacin_Studiranja = nacin_studiranja,
                Obnavlja_Godinu = obnavlja_godinu,
                Ovjeren_Semestar = ovjeren_semestar,
                Prezime = prezime,
                Prosjecna_Ocjena = prosjecna_ocjena,
                Spol = spol,
                Status = status,
                Telefon = telefon,
                Upisan_Semestar = upisan_semestar,
                KorisničkiNalog_ID = new KorisničkiNalog() { Aktivan = false, KorisnickoIme = ime + "." + prezime, Sifra = ime.Substring(0, 1) + prezime.Substring(0, 1) + "_" + rand.Next().ToString().Substring(0, 5) }

            };

            if (temp == null)
                return View("Error");

            db.Add(temp);
            db.SaveChanges();

            TempData["uspjesno"] = "USPJEŠNO STE DODALI";

            var code = HelperFunctions.CalculateMD5Hash(temp.Broj_Dosijea + temp.Datum_Rodjenja + temp.Mail + temp.KorisničkiNalog_ID.KorisnickoIme);
            var callbackUrl = HelperFunctions.GetBaseUrl(_httpCA) + $"/KorisnickiNalog/Aktivacija?userID={temp.PolaznikID}&&code={code}";
            TempData["uspjesno"] = "USPJEŠNO STE DODALI";
            await _emailSender.sendEMailAsync(temp.Mail, "Mail aktivacija", $"Vaši podaci su: {temp.KorisničkiNalog_ID.KorisnickoIme}, {temp.KorisničkiNalog_ID.Sifra}. Potrebno je još da izvršite aktivaciju Vašeg računa klikom <a href='{callbackUrl.ToString()}'> ovdje</a>");
            return Redirect("Prikaz");

        }

        public IActionResult UrediForm(int id)
        {
            Polaznik tmp = db.Polaznik.Where(x => x.PolaznikID == id).SingleOrDefault();
            ViewData["uredi"] = tmp;

            return View();
        }

        public IActionResult Uredi(int id, string ime, string prezime, string mail, DateTime datum_rodjenja, string adresa, string telefon, string spol, string broj_dosijea, string status, string nacin_studiranja, int upisan_semestar, int ovjeren_semestar, int godina_upisa, int godina_studija, string obnavlja_godinu, float prosjecna_ocjena)
        {
            Polaznik tmp = db.Polaznik.Where(x => x.PolaznikID == id).SingleOrDefault();

            tmp.Adresa = adresa;
            tmp.Broj_Dosijea = broj_dosijea;
            tmp.Datum_Rodjenja = datum_rodjenja;
            tmp.Godina_Studija = godina_studija;
            tmp.Godina_Upisa = godina_upisa;
            tmp.Ime = ime;
            tmp.Mail = mail;
            tmp.Nacin_Studiranja = nacin_studiranja;
            tmp.Obnavlja_Godinu = obnavlja_godinu;
            tmp.Ovjeren_Semestar = ovjeren_semestar;
            tmp.Prezime = prezime;
            tmp.Prosjecna_Ocjena = prosjecna_ocjena;
            tmp.Spol = spol;
            tmp.Status = status;
            tmp.Telefon = telefon;
            tmp.Upisan_Semestar = upisan_semestar;

            TempData["uspjesno"] = "USPJEŠNO STE UREDILI";

            db.SaveChanges();
            return Redirect("/Polaznici/Prikaz");
        }
    }
}