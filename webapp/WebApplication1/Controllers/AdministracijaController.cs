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
    public class AdministracijaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly MyContext db;
        private readonly IEmailSender _emailSender;
        private readonly IHttpContextAccessor _httpCA;

        public AdministracijaController(MyContext _db, IEmailSender emailSender, IHttpContextAccessor httpCA)
        {
            db = _db;
            _emailSender = emailSender;
            _httpCA = httpCA;
        }

        public ActionResult Prikaz()
        {
            

            List<PrikazAdministracije> podaci = db.Administracija.Select(x => new PrikazAdministracije
            {
                administracija_Id=x.AdministracijaID,
                adresa=x.Adresa,
                datum_rodjenja=x.Datum_Rodjenja,
                datum_zaposlenja=x.Datum_Zaposlenja,
                ime=x.Ime,
                kancelarija=x.Kancelarija,
                mail=x.Mail,
                prezime=x.Prezime,
                spol=x.Spol,
                stalan_zapolsenik=x.Stalan_Zapolsenik,
                staz=x.Staz,
                telefon=x.Telefon
            }).ToList();

            ViewData["administracija"] = podaci;

            return View();
        }
        
        public IActionResult DodajForm()
        {
            return View();
        }

        public async Task<IActionResult> Dodaj(string ime, string prezime, string mail, DateTime datum_rodjenja, DateTime datum_zaposlenja, string adresa, string telefon, string spol, int staz, string stalan_zaposlenik, string kancelarija)
        {
            Administracija temp = new Administracija
            {
                Adresa = adresa,
                Datum_Rodjenja = datum_rodjenja,
                Datum_Zaposlenja = datum_zaposlenja,
                Ime = ime,
                Kancelarija = kancelarija,
                Mail = mail,
                Prezime = prezime,
                Spol = spol,
                Stalan_Zapolsenik=stalan_zaposlenik,
                Staz = staz,
                Telefon = telefon,
                KorisničkiNalog_ID_FK=1,
            };

            if (temp == null)
                return View("Error");

            db.Add(temp);
            db.SaveChanges();

            var korisnickiPodaci = db.KorisničkiNalog.FirstOrDefault(x => x.KorisnickiNalogID == 1);

            string poruka2 = "USPJEŠNO STE DODALI";
            TempData["Success"] = poruka2;
            var code = HelperFunctions.CalculateMD5Hash(temp.Ime + temp.Prezime + temp.Datum_Rodjenja + temp.Mail + korisnickiPodaci.KorisnickoIme);
            var callbackUrl = HelperFunctions.GetBaseUrl(_httpCA) + $"/KorisnickiNalog/AktivacijaAdministracija?AdministracijaID={temp.AdministracijaID}&&code={code}";

            await _emailSender.sendEMailAsync(temp.Mail, "Mail aktivacija", $"Vaši podaci su: {korisnickiPodaci.KorisnickoIme}, {korisnickiPodaci.Sifra}. Potrebno je još da izvršite aktivaciju Vašeg računa klikom <a href='{callbackUrl.ToString()}'> ovdje</a>");

            return Redirect("Prikaz");
        }

        public IActionResult UrediForm(int id)
        {
            Administracija tmp = db.Administracija.Where(x => x.AdministracijaID == id).SingleOrDefault();

            ViewData["Uredi"] = tmp;

            return View();
        }

        public IActionResult Uredi(int id, string ime, string prezime, string mail, DateTime datum_rodjenja, DateTime datum_zaposlenja, string adresa, string telefon, string spol, int staz, string stalan_zaposlenik, string kancelarija)
        {
            Administracija tmp = db.Administracija.Where(x => x.AdministracijaID == id).SingleOrDefault();

            tmp.AdministracijaID = id;
            tmp.Adresa = adresa;
            tmp.Datum_Rodjenja = datum_rodjenja;
            tmp.Datum_Zaposlenja = datum_zaposlenja;
            tmp.Ime = ime;
            tmp.Kancelarija = kancelarija;
            tmp.Mail = mail;
            tmp.Prezime = prezime;
            tmp.Spol = spol;
            tmp.Stalan_Zapolsenik = stalan_zaposlenik;
            tmp.Staz = staz;
            tmp.Telefon = telefon;

            db.SaveChanges();
            string poruka2 = "USPJEŠNO STE UREDILI";
            TempData["Success"] = poruka2;
            return Redirect("/Administracija/Prikaz");
        }
                
        public IActionResult Ukloni(int id)
        {
            Administracija tmp = db.Administracija.Where(a => a.AdministracijaID == id).SingleOrDefault();

            if (tmp == null)
                return View("Error");
            try
            {
                db.Remove(tmp);
                db.SaveChanges();
            }catch (Exception)
            {
                string poruka = "PRVO UKLONITE DETALJE I IZMIJENITE UPLATE";
                TempData["Error"] = poruka;
                return Redirect("/Administracija/Prikaz");
            }
            string poruka2 = "USPJEŠNO STE UKLONULI";
            TempData["Success"] = poruka2;
            return Redirect("/Administracija/Prikaz");
        }
        public IActionResult DodajNovog()
        {
            return View();
        }
        public async Task<IActionResult> SnimiNovog(string Adresa, DateTime Datum_Rodjenja, DateTime Datum_Zaposlenja, string Ime, string Prezime, string Mail, string Telefon, string Spol, int Staz, string Stalan_Zaposlenik, string Kancelarija)
        {
            Administracija temp = new Administracija
            {
                Adresa = Adresa,
                Datum_Rodjenja = Datum_Rodjenja,
                Datum_Zaposlenja = Datum_Zaposlenja,
                Ime = Ime,
                Kancelarija = Kancelarija,
                Mail = Mail,
                Prezime = Prezime,
                Spol = Spol,
                Stalan_Zapolsenik = Stalan_Zaposlenik,
                Staz = Staz,
                Telefon = Telefon,
                KorisničkiNalog_ID_FK = 1,
            };

            if (temp == null)
                return View("Error");

            db.Add(temp);
            db.SaveChanges();

            var korisnickiPodaci = db.KorisničkiNalog.FirstOrDefault(x => x.KorisnickiNalogID == 1);

            string poruka2 = "USPJEŠNO STE DODALI";
            TempData["Success"] = poruka2;
            var code = HelperFunctions.CalculateMD5Hash(temp.Ime + temp.Prezime + temp.Datum_Rodjenja + temp.Mail + korisnickiPodaci.KorisnickoIme);
            var callbackUrl = HelperFunctions.GetBaseUrl(_httpCA) + $"/KorisnickiNalog/AktivacijaAdministracija?AdministracijaID={temp.AdministracijaID}&&code={code}";

            await _emailSender.sendEMailAsync(temp.Mail, "Mail aktivacija", $"Vaši podaci su: {korisnickiPodaci.KorisnickoIme}, {korisnickiPodaci.Sifra}. Potrebno je još da izvršite aktivaciju Vašeg računa klikom <a href='{callbackUrl.ToString()}'> ovdje</a>");

            return Redirect("Prikaz");
        }
    }
}