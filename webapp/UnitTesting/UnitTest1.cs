using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WebApplication1.Controllers;
using WebApplication1.EF;
using WebApplication1.Models;
using WebApplication1.Models.VM;
using WebApplication1.Service;

namespace UnitTesting
{

    //[TestClass]
    //public class KorisnickiNalogControllerTest
    //{
    //    private readonly MyContext db;

    //    [TestMethod]
    //    public void Login_Redirect_User_does_not_exists()
    //    {
    //        LoginVM input = new LoginVM();
    //        input.Username = "KorisnikNePostoji";
    //        input.Password = "SifraSeNePodudara";
    //        KorisnickiNalogController KNK = new KorisnickiNalogController(db);
    //        var result = KNK.Login(input);
    //        var parsedResult = result as Microsoft.AspNetCore.Mvc.ViewResult;
    //        Assert.AreEqual("Index", parsedResult.ViewName);
    //    }
    //}
    //[TestClass]
    //public class AdministracijaControllerTest
    //{
    //    public MyContext db;
    //    public AdministracijaControllerTest(MyContext _db)
    //    {
    //        db = _db;
    //    }

    //    [TestMethod]
    //    public void IndexView_NotNull()
    //    {
    //        AdministracijaController ac = new AdministracijaController(db);
    //        Assert.IsNotNull(ac.Index());
    //    }
    //    [TestMethod]
    //    public void PrikazView_NotNull()
    //    {
    //        AdministracijaController ac = new AdministracijaController(db);
    //        Assert.IsNotNull(ac.Prikaz());
    //    }
    //}
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void IndexView_NotNull()
        {
            HomeController hc = new HomeController();
            hc.Index();
            Assert.IsNotNull(hc.Index());
        }
        [TestMethod]
        public void PrivacyView_NotNull()
        {
            HomeController hc = new HomeController();
            Assert.IsNotNull(hc.Privacy());
        }
        [TestMethod]
        public void AboutView_View_Message()
        {
            HomeController hc = new HomeController();
            Microsoft.AspNetCore.Mvc.ViewResult vr = hc.About() as Microsoft.AspNetCore.Mvc.ViewResult;
            Assert.AreEqual(vr.ViewData["Message"], "Your application description page.");
        }
        [TestMethod]
        public void ContactView_View_Message()
        {
            HomeController hc = new HomeController();
            Microsoft.AspNetCore.Mvc.ViewResult vr = hc.About() as Microsoft.AspNetCore.Mvc.ViewResult;
            Assert.AreEqual(vr.ViewData["Message"], "Your application description page.");
        }
    }

    [TestClass]
    public class PolazniciTest
    {
        private static readonly MyContext db;
        private static readonly IEmailSender _emailSender;
        private static readonly IHttpContextAccessor _httpCA;

        PolazniciController pc = new PolazniciController(db, _emailSender, _httpCA);


        //[TestMethod]
        //public void View_Prikaz_Return_Not_Null()
        //{
        //    var temp = pc.Prikaz();

        //    Assert.IsNotNull(temp);
        //}

        [TestMethod]
        public void View_DodajForm_Return_Not_Null()
        {
            Assert.IsNotNull(pc.DodajForm());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void There_Is_Exception_In_Action_Ukloni()
        {
            pc.Ukloni(-1);
        }

        [TestMethod]
        public void DodajForm_Return_Not_Null()
        {
            Assert.IsNotNull(pc.DodajForm());
        }
    }

    [TestClass]
    public class UplateTest
    {

        UplateController uc = new UplateController(db);
        private static readonly MyContext db;

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void There_Is_Exception_In_Action_UkloniUplatu()
        {
            uc.UkloniUplatu(-10);
        }

        //[TestMethod]
        //public void PrikaiUplate_Return_Not_Null()
        //{
        //    Assert.IsNotNull(uc.PrikaziUplate());
        //}

        //[TestMethod]
        //public void DodajUplateForm_Return_Not_Null()
        //{
        //    Assert.IsNotNull(uc.DodajUplateForm());
        //}


    }
}
