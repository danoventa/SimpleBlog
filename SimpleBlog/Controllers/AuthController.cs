using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View(new AuthLogin
            {
                // Test = "This is my test value set in my controller!"
            });
        }
        
        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid)
                return View(form);

            if (form.Username != "rainbow dash")
            {
                ModelState.AddModelError("Username", "UserName or Password isn't correct.");
                return View(form);
            }

            // form.Test = "This is a value set in my post action";
            return Content("The form is valid");
        }
    }
}