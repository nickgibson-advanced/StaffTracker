using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using StaffTracker.Extensions;
using Microsoft.AspNet.Identity.Owin;
using StaffTracker.Models;

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
        [AllowAnonymous]
        public async Task<ActionResult> UpdateShift(FormCollection FormData)
        {
            var latitude = FormData["coords[latitude]"];
            var longtitude = FormData["coords[longitude]"];
            var checkinTime = DateTime.Now;

            //Is employee at work?
            ApplicationUserManager UserManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();

            var userId = User.Identity.GetUserId();
            var user = UserManager.FindById(userId);

            user.AtWork = !user.AtWork;

            UserLog userLog = new UserLog()
            {
                UserLogID = Guid.NewGuid(),
                DateTimeStamp = checkinTime,
                UserId = userId,
                Latitude = latitude,
                Longtitude = longtitude
            };

            user.UserLogs.Add(userLog);

            var updateUser = await UserManager.UpdateAsync(user);

            string ReturnUrl = "";
            return Json(ReturnUrl);
        }
    }
}