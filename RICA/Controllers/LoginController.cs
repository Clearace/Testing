using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RICA.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login(string user, string pass)
        {
            
            return View();
        }

        // GET: Login/Register
        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }

        // POST: Login/Register
        [HttpPost]
        public ActionResult Register(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Reset Password
        public ActionResult Reset(int id)
        {
            return View();
        }

        // POST: Login/Reset password
        [HttpPost]
        public ActionResult Reset(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
