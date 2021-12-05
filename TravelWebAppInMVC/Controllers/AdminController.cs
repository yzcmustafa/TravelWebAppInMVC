using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelWebAppInMVC.Models.Classes;
namespace TravelWebAppInMVC.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogDelete(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGet(int id)
        {
            var b = c.Blogs.Find(id);
            return View("BlogGet", b);
        }
        public ActionResult BlogUpdate(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Title = b.Title;
            blg.Contents = b.Contents;
            blg.BlogImage = b.BlogImage;
            blg.Date = b.Date;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}