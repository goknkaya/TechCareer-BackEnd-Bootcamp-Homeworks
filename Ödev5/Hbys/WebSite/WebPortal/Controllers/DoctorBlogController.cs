using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPortal.Controllers
{
    public class DoctorBlogController : Controller
    {
        // GET: DoctorBlog
        public ActionResult Index()
        {
            return View();
        }
    }
}