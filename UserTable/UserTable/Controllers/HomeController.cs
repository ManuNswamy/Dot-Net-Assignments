using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserTable.Models;

namespace UserTable.Controllers
{
    public class HomeController : Controller
    {
        public static List<UserDetails> user_list = new List<UserDetails>()
        {
            new UserDetails(){  Student_ID = 1, Student_Name = "Harshada", Student_Password ="123"},
            new UserDetails(){  Student_ID = 2, Student_Name = "Anitha", Student_Password="321"}
        };
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllUserDetails()
        {
            return Json(user_list, JsonRequestBehavior.AllowGet);
        }
        public ActionResult FormSubmitted(UserDetails user_detail)
        {
            user_list.Add(user_detail);
            return Redirect("Index");
        }
        public ActionResult SearchUserData(string Student_Name)
        {

                   
            return Json(user_list.Where(u => u.Student_Name.Contains(Student_Name)).ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}