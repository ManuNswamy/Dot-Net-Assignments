using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public class Blog
        {
            public string Name;
            public string URL;
        }

        private readonly List<Blog> TopBlogs = new List<Blog> {
         new Blog { Name = "Joe Delage", URL = "http://tutorialspoint/joe/"},
         new Blog {Name = "Mark Dsouza", URL = "http://tutorialspoint/mark"},
         new Blog {Name = "Michael Shawn", URL = "http://tutorialspoint/michael"}
        };

        public ActionResult Index()
        {
            return View(TopBlogs);
        }

        public ActionResult MyView()
        {
            return View(TopBlogs);
        }
    }
}