using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelWebAppInMVC.Models.Classes;
namespace TravelWebAppInMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var Values = c.Blogs.Take(4).ToList();
            return View(Values);
        }

        public ActionResult About()
        {

            return View();
        }
        public PartialViewResult Partial1()
        {
            var values = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var values = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial3()
        {
            var values = c.Blogs.ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial4()
        {
            var Values = c.Blogs.Take(3).ToList();
            return PartialView(Values);
        }
        public PartialViewResult Partial5()
        {
            var Values = c.Blogs.Take(3).ToList();
            return PartialView(Values);
        }
    }
}