using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Casestudyb.Models;

namespace Casestudyb.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
           

            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            if (ModelState.IsValid)
            {
               FoodEntities db = new FoodEntities();
                var user = (from userlist in db.Customers
                            where userlist.UserName == login.UserName && userlist.Pwdwrd == login.Pwdwrd
                            select new
                            {
                                userlist.Customerid,
                                userlist.UserName
                            }).ToList();
                if (user.FirstOrDefault() != null)
                {
                    Session["UserName"] = user.FirstOrDefault().UserName;
                    Session["UserID"] = user.FirstOrDefault().Customerid;
                    return Redirect("Welcomepage");

                }
                else
                {
                    ModelState.AddModelError("", "Invalid Login credentials");
                }

            }
            return View(login);
        }
        public ActionResult Welcomepage()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Signup(Customer obj)
        {
            if (ModelState.IsValid)
            {
                FoodEntities db = new FoodEntities();
                db.Customers.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }

        public ActionResult Adminlogin()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Adminlogin(Userpassword adlog)
        {
            if (ModelState.IsValid)
            {
                FoodEntities db = new FoodEntities();
                var user = (from userlist in db.Userpasswords
                            where userlist.Usr == adlog.Usr && userlist.Pwd == adlog.Pwd
                            select new
                            {
                                userlist.Id,
                                userlist.Usr
                            }).ToList();
                if (user.FirstOrDefault() != null)
                {
                    Session["UserName"] = user.FirstOrDefault().Usr;
                    Session["UserID"] = user.FirstOrDefault().Id;
                    return Redirect("Adminpage");

                }
                else
                {
                    ModelState.AddModelError("", "Invalid Login credentials");
                }

            }
            return View(adlog);
        }
        public ActionResult Adminpage()
        {
            return View();
        }


    }
}