﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Controllers
{
    public class CookieDemoController : Controller
    {
        // GET: CookieDemo
        public ActionResult Index()
        {
            int count = 1;

            var cookie = Request.Cookies["count"];
            if (cookie == null)
            {
                Response.Cookies.Add(new HttpCookie("count", "1"));
            }
            else
            {
                count = int.Parse(cookie.Value) + 1;
                var newcookie = new HttpCookie("count", count.ToString());
                newcookie.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(newcookie);
            }

            ViewBag.count = count;
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult PostLogin(string username, string password)
        {
            if (username == "abc" && password == "123")
            {
                var cookie = new HttpCookie("isauth", "true");
                Response.Cookies.Add(cookie);
                return RedirectToAction("AddArticle", "Blog");
            }
            return View();
        }
    }
}