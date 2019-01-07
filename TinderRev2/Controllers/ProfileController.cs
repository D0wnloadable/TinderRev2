using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TinderRev2.Models;

namespace TinderRev2.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult ListProfiles()
        {
            List<ProfileModel> list = new List<ProfileModel>();

            list.Add(new ProfileModel { FirstName = "Erik", LastName = "Asplund" });
            list.Add(new ProfileModel { FirstName = "Sven", LastName = "Asplund" });
            list.Add(new ProfileModel { FirstName = "Lars", LastName = "Asplund" });

            return View(list);
        }
    }
}