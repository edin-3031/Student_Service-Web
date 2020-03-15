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
    public class AjaxController : Controller
    {
        private readonly MyContext db;

        public AjaxController(MyContext _db)
        {
            db = _db;
        }

        public IActionResult DetaljiKurs(int SP_id, int kursId)
        {
            detaljiKursVM model = db.Studijski_Program.Where(a => a.Studijski_programID == SP_id).Select(x => new detaljiKursVM()
            {
                sp_naziv = x.Naziv,
                akademija = x.Akademija_ID.Naziv,
                cijena = x.Cijena,
                trajanje = x.Trajanje,
                kurs = db.Kurs.Where(a => a.KursID == kursId).Select(o => o.Naziv).SingleOrDefault(),
            }).SingleOrDefault();

            ViewData["kurs"] = db.Kurs.Where(y => y.KursID == kursId).Select(o => o.Naziv).SingleOrDefault();

            return PartialView(model);
        }


        public IActionResult DetaljiPolaznik(int id)
        {
            List<detaljiPolaznikVM> model = db.Pohadja.Where(a => a.Polaznik_FK_ID.PolaznikID == id).Select(x => new detaljiPolaznikVM
            {
                Broj_Obnavljanja = x.Broj_Obnavljanja,
                kraj = x.Kraj,
                Obnavlja = x.Obnavlja,
                pocetak = x.Pocetak,
                kurs = db.Kurs.Where(v=>v.KursID==x.KursID_FK).Select(o=>o.Naziv).SingleOrDefault(),
                pohadjaID=x.PohadjaID
            }).ToList();

            row model2 = new row
            {
                rows = model
            };

            ViewData["polaznik"] = db.Polaznik.Where(y=>y.PolaznikID==id).Select(c=>c.Ime+" "+c.Prezime).SingleOrDefault();
            ViewData["polaznikID"] = id;

            return PartialView(model2);
        }

        public IActionResult DetaljiAdministracija(int id)
        {
            List<detaljiAdministracijaVM> lista = db.Radi.Where(a => a.AdministracijaId.AdministracijaID == id).Select(x => new detaljiAdministracijaVM
            {
                Akademija=x.AkademijaId.Naziv,
                broj_sati_u_sedmici=x.Broj_Sati_U_Sedmici,
                plata=x.Plata,
                vrsta_ugovora=x.Vrsta_Ugovora,
                rad_id=x.RadiID
            }).ToList();

            adminROW model = new adminROW
            {
                row = lista
            };

            ViewData["admin"] = db.Administracija.Where(a => a.AdministracijaID == id).Select(c => c.Ime + " " + c.Prezime).SingleOrDefault();
            ViewData["id_admin"] = id;

            return PartialView(model);
        }

        public IActionResult DeteljiProfesorRadi(int id)
        {
            List<detaljiAdministracijaVM> lista = db.Radi.Where(a => a.ProfesorId_FK == id).Select(x => new detaljiAdministracijaVM
            {
                Akademija=x.AkademijaId.Naziv,
                broj_sati_u_sedmici=x.Broj_Sati_U_Sedmici,
                plata=x.Plata,
                vrsta_ugovora=x.Vrsta_Ugovora,
                rad_id=x.RadiID,
                profesor_id=id
            }).ToList();

            adminROW model = new adminROW
            {
                row = lista
            };

            ViewData["prof_radi"] = db.Profesor.Where(a => a.ProfesorID == id).Select(c => c.Ime + " " + c.Prezime).SingleOrDefault();
            ViewData["prof_id"] = id;

            return PartialView(model);
        }

        public IActionResult DetaljiProfesorPredaje(int id)
        {
            List<profPredajeVM> lista = db.Predaje.Where(a => a.ProfesorId_FK == id).Select(x => new profPredajeVM
            {
                datum_predavanja=x.Datum_Predavanja,
                kurs=x.KursId.Naziv,
                odrzano=x.Odrzano,
                opis=x.Opis,
                vrsta=x.Vrsta,
                predaje_id=x.PredajeID
            }).ToList();

            RowProfPredajeVM model = new RowProfPredajeVM
            {
                row = lista
            };

            ViewData["prof_predaje"] = db.Profesor.Where(a => a.ProfesorID == id).Select(c => c.Ime + " " + c.Prezime).SingleOrDefault();
            ViewData["prof_ID"] = id;

            return PartialView(model);
        }

        public IActionResult DodajDetaljePolaznik(int id)
        {
            ViewData["polaznik"] = db.Polaznik.Where(a => a.PolaznikID == id).SingleOrDefault();

            detaljiPolaznikPohadjaVM model = new detaljiPolaznikPohadjaVM
            {
                lista = db.Kurs.ToList(),
                polaznikID = id
            };

            ViewData["polaznik_ID"] = id;

            return PartialView(model);
        }

        public IActionResult DetaljiPolaznikSnimi(int polaznikID, int kursID, DateTime pocetak, DateTime kraj, string obnavlja, int broj_obnavljanja)
        {
            Pohadja tmp = new Pohadja
            {
                Broj_Obnavljanja=broj_obnavljanja,
                Kraj=kraj,
                KursID_FK=kursID,
                Obnavlja=obnavlja,
                Pocetak=pocetak,
                PolaznikID_FK=polaznikID,
            };

            db.Add(tmp);

            db.SaveChanges();

            return Redirect("/Ajax/DetaljiPolaznik?id="+polaznikID);
        }

        public IActionResult UkloniDetaljPolaznik(int id, int polaznikID)
        {
            Pohadja tmp = db.Pohadja.Where(a => a.PohadjaID == id).SingleOrDefault();
            if (tmp == null)
                return View("Error");

            db.Remove(tmp);
            db.SaveChanges();

            return Redirect("/Ajax/DetaljiPolaznik?id=" + polaznikID);
        }

        public  IActionResult DodajDetaljePredavanja(int id)
        {
            detaljiPredajeVM model = new detaljiPredajeVM
            {
                kursevi = db.Kurs.ToList(),
                profesorID = id
            };
            ViewData["id_back_2"] = id;
            return PartialView(model);
        }

        public IActionResult SnimiDetaljePredavanja(int profesor_ID, int Kurs_ID, DateTime datum, string odrzano, string vrsta, string opis)
        {
            Predaje tmp = new Predaje
            {
                Datum_Predavanja = datum,
                KursId_FK = Kurs_ID,
                Odrzano = odrzano,
                Opis = opis,
                ProfesorId_FK = profesor_ID,
                Vrsta = vrsta
            };

            db.Add(tmp);
            db.SaveChanges();

            return Redirect("/Ajax/DetaljiProfesorPredaje?id=" + profesor_ID);
        }

        public IActionResult UkloniPredavanjeDetalj(int id, int prof_iD)
        {
            Predaje tmp = db.Predaje.Where(a => a.PredajeID == id).SingleOrDefault();

            if (tmp == null)
                return View("Error");

                db.Remove(tmp);
                db.SaveChanges();


            return Redirect("/Ajax/DetaljiProfesorPredaje?id=" + prof_iD);
        }

        public IActionResult UkloniDetaljeRadi(int id, int prof_id)
        {
            Radi tmp = db.Radi.Where(a => a.RadiID == id).SingleOrDefault();

            if (tmp == null)
                return View("Error");

            db.Remove(tmp);
            db.SaveChanges();

            return Redirect("/Ajax/DeteljiProfesorRadi?id="+ prof_id);
        }

        public IActionResult DodajDetaljeRadi(int id)
        {
            DodajDetaljeRadiVM model = new DodajDetaljeRadiVM
            {
                akademije = db.Akademija.ToList(),
                radnikID = id
            };

            ViewData["id_back"] = id;

            return PartialView(model);
        }

        public IActionResult SnimiDetaljeRada(int ID, int akademijaID, int broj_sati, float plata, string ugovor)
        {
            Radi tmp = new Radi
            {
                AkademijId_FK = akademijaID,
                ProfesorId_FK = ID,
                Vrsta_Ugovora = ugovor,
                Plata = plata,
                Broj_Sati_U_Sedmici = broj_sati
            };

            db.Add(tmp);
            db.SaveChanges();

            return Redirect("/Ajax/DeteljiProfesorRadi?id="+ID);
        }

        public IActionResult DodajRadAdministrator(int idAdmin)
        {
            DodajDetaljeRadiVM model = new DodajDetaljeRadiVM
            {
                akademije = db.Akademija.ToList(),
                radnikID= idAdmin
            };

            ViewData["_id_"] = idAdmin;

            return PartialView(model);
        }

        public IActionResult SnimiRadAdministracija(int radnikID, int akademijaID, int broj_sati, float plata, string ugovor)
        {
            Radi tmp = new Radi
            {
                Administracija_FK = radnikID,
                AkademijId_FK = akademijaID,
                Broj_Sati_U_Sedmici = broj_sati,
                Plata = plata,
                Vrsta_Ugovora = ugovor
            };

            db.Add(tmp);
            db.SaveChanges();

            return Redirect("/Ajax/DetaljiAdministracija?id=" + radnikID);
        }

        public IActionResult UkloniDetaljeAdministracijaRadi(int id, int admin_id)
        {
            Radi tmp = db.Radi.Where(a => a.RadiID == id).SingleOrDefault();

            if (tmp == null)
                return View("Error");

            db.Remove(tmp);
            db.SaveChanges();

            return Redirect("/Ajax/DetaljiAdministracija?id=" + admin_id);
        }

    }
}