using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.EF;
using WebApplication1.Models.VM;
using WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using WebApplication1.Helper;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    public class KorisnickiNalogController : Controller
    {
        private readonly MyContext db;
        private readonly IEmailSender _emailSender;

        public KorisnickiNalogController(MyContext _db,IEmailSender emailSender)
        {
            db = _db;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            LoginVM model = new LoginVM();
            return View("Index",model);
        }


        public IActionResult Login(LoginVM input)
        {
            KorisničkiNalog korisnik = db.KorisničkiNalog.SingleOrDefault(x => x.KorisnickoIme == input.Username && x.Sifra == input.Password);

            if(korisnik==null)
            {
                ViewData["error_poruka"] = "Uneseni podaci su neispravni";
                return View("Index", input);
            }

            if (korisnik.Aktivan == false)
            {
                ViewData["error_poruka"] = "Račun nije aktiviran";
                return View("Index", input);
            }

            HttpContext.Session.SetString("Key", korisnik.KorisnickoIme);

            return RedirectToAction("About","Home");
        }
        public async Task<IActionResult> Aktivacija(int userID, string code)
        {
            if (userID == null || code == null)
            {
                return RedirectToPage("/Index");
            }
            Polaznik p = db.Polaznik.Include(x => x.KorisničkiNalog_ID).Where(x => x.PolaznikID == userID).Select(x => new Polaznik()
            {
                Datum_Rodjenja = x.Datum_Rodjenja,
                Broj_Dosijea = x.Broj_Dosijea,
                Mail = x.Mail,
                KorisničkiNalog_ID = x.KorisničkiNalog_ID
            }).FirstOrDefault();


            if (p == null)
            {
                return NotFound($"Unable to load user with ID '{userID}'.");
            }

            var result = HelperFunctions.CalculateMD5Hash(p.Broj_Dosijea + p.Datum_Rodjenja + p.Mail + p.KorisničkiNalog_ID.KorisnickoIme);

            if (result.Equals(code))
            {
                p.KorisničkiNalog_ID.Aktivan = true;
                db.SaveChanges();
                await _emailSender.sendEMailAsync(p.Mail,"Aktivacija korisnickog racuna",$"Uspješno ste aktivirali Vaš račun. Dobrodošli u IT Academy tim.");
                return Redirect("/Home/Contact");
            }


            return RedirectToAction("About", "Home");
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Index");
        }
    }
}