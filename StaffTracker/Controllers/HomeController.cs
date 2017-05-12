using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using StaffTracker.Extensions;
using Microsoft.AspNet.Identity.Owin;

namespace StaffTracker.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            //Is employee at work?
            ApplicationUserManager UserManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();

            var userId = User.Identity.GetUserId();
            var user = UserManager.FindById(userId);

            //user.AtWork = true;
            //UserManager.Update(user);

            ViewBag.AtWork = user.AtWork;

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

        [HttpPost]
        public ActionResult RecordLocation()
        {
            return RedirectToAction("Index");
        }
    }
}