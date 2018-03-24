using InternetShop.Contracts.DataContracts;
using InternetShop.DAL.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new InternetShopContext())
            {
                context.Users.Add(new User() { Password = "123", ConfirmPassword = "123", Surname = "Vasiy", Name = "Petya" });
                var a = context.Users;
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}