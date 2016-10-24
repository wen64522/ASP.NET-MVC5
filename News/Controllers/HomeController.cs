using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Controllers
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

        public ActionResult Welcome()
        {
            var a = 100;
            var sum = 0;
            for (var i = 1; i <= a; i++)
            {
                sum += i;
            }

            ViewBag.sum = sum;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult List(int page=4)
        {
            string[] data = new string[] { "werewrewrfew", "dwqdwqdwqd", "wqewqewq", "drwqrdwq" };
            ViewBag.data = data;
            ViewBag.Page = page;
            return View();
        }
        public ActionResult Add()
        {

            return View();
        }
        public ActionResult Save(string title,string content)
        {
            ViewBag.Title = title;
            ViewBag.Conetent = content;
            return View();
        }
    }
}