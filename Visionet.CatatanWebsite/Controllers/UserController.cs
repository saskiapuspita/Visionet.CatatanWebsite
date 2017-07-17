using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Visionet.CatatanWebsite.DAL;

namespace Visionet.CatatanWebsite.Controllers
{
    public class UserController : Controller
    {
        private CatatanContext db = new CatatanContext();
        //GET USER
        public ActionResult Index()
        {
            var user = from a in db.UserModels
                       select a;
            return View(user);
        }

        // GET: Student/Details/5
        public ActionResult Details()
        {
            return View();
        }
    }
    
}