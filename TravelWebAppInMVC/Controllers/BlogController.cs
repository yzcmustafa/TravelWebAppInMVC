using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelWebAppInMVC.Models.Classes;

namespace TravelWebAppInMVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogComment bc = new BlogComment();
        public ActionResult Index()
        {
            //var blogs = c.Blogs.ToList();
            bc.Value1 = c.Blogs.ToList();
            bc.Value3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(bc);
        }
        public ActionResult BlogDetail(int id)
        { 
            //var blogSearch = c.Blogs.Where(x => x.ID == id).ToList();
            bc.Value1 = c.Blogs.Where(x => x.ID == id).ToList();
            bc.Value2 = c.Comments.Where(x => x.BlogID == id).ToList();
            return View(bc);
        }
    }
}