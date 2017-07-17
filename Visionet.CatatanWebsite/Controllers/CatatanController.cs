using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Visionet.CatatanWebsite.DAL;
using Visionet.CatatanWebsite.Models;

namespace Visionet.CatatanWebsite.Controllers
{
    public class CatatanController : Controller
    {
        private CatatanContext db;
        
        public CatatanController()
        {
            db = new CatatanContext();
        }

        public ActionResult Index()
        {

            return View();
        }

        //public JsonResult GetBlogDetailByCategoryID(int categoryId)
        //{
        //    List<CatatanController> blogs = new List<CatatanController>();
        //    blogs = db.Blogs.Where(x => x.CategoryId == categoryId).Take(5).ToList();
        //    return Json(blogs, JsonRequestBehavior.AllowGet);
        //}

        public JsonResult GetCatatanMelaluiUserId(int userID)
        {
            db.CatatanModels.Where(catatan => catatan.ID_user == userID).ToList();
            throw new NotImplementedException("Belum selesai dibuat.");
        }

        public IList<Catatan> GetCatatanByUserId(int userID)
        {
            return db.CatatanModels.Where(catatan => catatan.ID_user == userID).ToList();
        }

        public ActionResult GetCatatanJsonByUserId(int userId)
        {
            var result = GetCatatanByUserId(userId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}