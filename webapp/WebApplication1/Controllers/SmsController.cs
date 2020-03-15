using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.TwiML;
using Twilio.AspNet.Core;
using WebApplication1.EF;


namespace WebApplication1.Controllers
{

    public class SmsController : TwilioController
    {
        private readonly MyContext db;


        public SmsController(MyContext _db)
        {
            db = _db;
        }

        public ActionResult SendSms(int polaznikID)
        {
            var accountSid = "AC6fdeb757756cf48afc36bc44cb97dfd0";
            var authToken = "10c0e033ab8b789ccb2d50133d7cdd29";

            TwilioClient.Init(accountSid, authToken);

            string phone = db.Polaznik.Where(x => x.PolaznikID == polaznikID).Select(y => y.Telefon).Single();
            string name = db.Polaznik.Where(x => x.PolaznikID == polaznikID).Select(y => y.Ime +" "+ y.Prezime).Single();

            var to = new PhoneNumber("+38762363542");
            var from = new PhoneNumber("+12038729535");

            var message = MessageResource.Create(
                to: to,
                from: from,
                body: "Poštovani "+name+ ", uspješno Vam je evidentirana uplata. Lijep pozdrav, IT Academy.");
            return Content(message.Sid);
        }


    }
}