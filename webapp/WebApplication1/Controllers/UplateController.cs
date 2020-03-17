using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.EF;
using WebApplication1.Models.VM;

namespace WebApplication1.Controllers
{
    public class UplateController : Controller
    {
        private readonly MyContext db;

        public UplateController(MyContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DodajUplateForm()
        {

            List<Polaznik> podaci = db.Polaznik.ToList();
            ViewData["Uplate_form"]=podaci;

            List<Administracija> podaci2 = db.Administracija.ToList();
            ViewData["Uplate_form2"] = podaci2;


            return View("ViewUplateForm");
        }

        public IActionResult DodajUplatu(string svrha, float iznos, DateTime datum_uplate, string ovjereno, int polaznik, int administracija)
        {

            Uplata temp = new Uplata()
            {
                Svrha = svrha,
                Iznos = iznos,
                Datum_uplate = datum_uplate,
                Ovjereno = ovjereno,
                Polaznik_ID_FK = polaznik,
                Administracija_ID_FK = administracija
            };

            db.Add(temp);
            db.SaveChanges();

            SmsController tmp = new SmsController(db);
            tmp.SendSms(polaznik);

            TempData["Success"] = "USPJEŠNO STE DODALI";


            return Redirect("/Uplate/PrikaziUplate");
        }

        public ActionResult UkloniUplatu(int TrazenaUplata)
        {
            if (TrazenaUplata < 0)
                throw new Exception("Unijeta je negativna vrijdnost za ID!");

            Uplata temp = db.Uplata.Where(x => x.UplataID == TrazenaUplata).SingleOrDefault();

            if (temp == null)
                return View("/Error");

            db.Remove(temp);
            db.SaveChanges();


            TempData["Success"] = "USPJEŠNO STE UKLONULI";

            return Redirect("/Uplate/PrikaziUplate");
        }

        public ActionResult PrikaziUplate()
        {

            List<PrikazUplata> podaci = db.Uplata.Select(x => new PrikazUplata
            {
                UplataID = x.UplataID,
                Svrha = x.Svrha,
                Iznos = x.Iznos,
                Datum_Uplate = x.Datum_uplate,
                Ovjereno = x.Ovjereno,
                Polaznik = x.Polaznik_ID.Ime+" "+x.Polaznik_ID.Prezime,
                Administracija = x.Administracija_ID.Ime +" "+ x.Administracija_ID.Prezime
            }).ToList();

            ViewData["uplata_id"] = podaci;

            return View("ViewUplate");
        }

        public IActionResult UrediForm(int id)
        {
            if (id < 0)
                throw new Exception("Unešen je negativan broj za ID!");

            Uplata tmp = db.Uplata.Where(y => y.UplataID == id).SingleOrDefault();
            if (tmp != null)
            {
                ViewData["Uredi"] = tmp;
                UrediFormVM model = new UrediFormVM
                {
                    listaAdministracije = db.Administracija.ToList(),
                    listaPolaznika = db.Polaznik.ToList()
                };
                return View(model);
            }
            else return View("Error");

        }

        public IActionResult Uredi(int id, string svrha, float iznos, DateTime datum_uplate, string ovjereno, int polaznik, int administracija)
        {
            Uplata tmp = db.Uplata.Where(x => x.UplataID == id).SingleOrDefault();

            tmp.UplataID = id;
            tmp.Iznos = iznos;
            tmp.Ovjereno = ovjereno;
            tmp.Polaznik_ID_FK = polaznik;
            tmp.Svrha = svrha;
            tmp.UplataID = id;
            tmp.Administracija_ID_FK = administracija;
            tmp.Datum_uplate = datum_uplate;

            db.SaveChanges();

            TempData["Success"] = "USPJEŠNO STE UREDILI";

            return Redirect("/Uplate/PrikaziUplate");
        }
        public IActionResult DodajNovu()
        {
            UplataDodajVM vm = new UplataDodajVM
            {
                polaznici = db.Polaznik
                .Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = x.PolaznikID.ToString(),
                    Text = x.Ime + " " + x.Prezime
                }).ToList(),
                administratori= db.Administracija
                .Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = x.AdministracijaID.ToString(),
                    Text = x.Ime + " " + x.Prezime
                }).ToList()
            };
            return View(vm);
        }
        //public IActionResult SnimiNovu(string Svrha, float Iznos, DateTime Datum_Uplate, string Ovjereno, int PolaznikID, int AdministracijaID)
        //{
        //    Uplata temp = new Uplata()
        //    {
        //        Svrha = Svrha,
        //        Iznos = Iznos,
        //        Datum_uplate = Datum_Uplate,
        //        Ovjereno = Ovjereno,
        //        Polaznik_ID_FK = PolaznikID,
        //        Administracija_ID_FK = AdministracijaID
        //    };

        //    db.Add(temp);
        //    db.SaveChanges();

            

        //    SmsController tmp = new SmsController(db);
        //    tmp.SendSms(PolaznikID);

        //    TempData["Success"] = "USPJEŠNO STE DODALI";


        //    return Redirect("/Uplate/PrikaziUplate");
        //}
    }
}