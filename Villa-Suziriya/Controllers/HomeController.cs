using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Villa_Suziriya.Models;

namespace Villa_Suziriya.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            return View();
        }

        [Authorize(Roles = "admin")]
        public ActionResult GetUsers()
        {
            var users = new List<ApplicationUser>();
            var db = new ApplicationDbContext();
            users = db.Users.ToList();
            return View(users);
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