using Angular_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Angular_Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        // GetAllUsers
        [HttpPost]
        public ActionResult GetAllUsers()
        {
            var list = new List<MySaverUsers>();
            MySaverUsers user1 = new MySaverUsers();
            user1.Id = 1;
            user1.name = "Amir";
            user1.age = 42;
            list.Add(user1);

            MySaverUsers user2 = new MySaverUsers();
            user2.Id = 2;
            user2.name = "Ali";
            user2.age = 36;
            list.Add(user2);

            MySaverUsers user3 = new MySaverUsers();
            user3.Id = 3;
            user3.name = "Afshin";
            user3.age = 31;
            list.Add(user3);


            try
            {
                var model = list;
                return Json(model, "application/json", System.Text.Encoding.UTF8);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                //Ignoring this and just sending back http 500 code.  It will retry anyhow....
                return new HttpStatusCodeResult((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}