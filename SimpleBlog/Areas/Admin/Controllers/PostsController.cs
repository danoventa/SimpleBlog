using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SimpleBlog.Controllers
{
    public class PostsController : Controller  // This was supposed to be subclassed into the Controller... That's why content did not work. 
    {
        // controller has actions we can map to. 
        public ActionResult Index()
        {
            return Content("Hello, World!");
        }
    }
}