using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicWindowsAuthentication.Controllers
{
    [Authorize(Users = @"XOR-IND\narayanswamy_s,SUBRAMANI-N\testuser")]
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }
    }
}