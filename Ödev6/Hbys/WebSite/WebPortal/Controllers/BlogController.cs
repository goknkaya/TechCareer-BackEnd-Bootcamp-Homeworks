using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace WebPortal.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            string OMessage;
            ViewBag.Blog = null;
            if (Request.QueryString.Count > 0)
            {
                string BlogLink = Request.RawUrl.Split('?')[1].Trim();
                if (BlogLink != null && BlogLink != "")
                {
                    TBusinessLayer BusinessLayer = new TBusinessLayer();
                    ViewBag.Blog = BusinessLayer.GetBlogDetailByLink(BlogLink, out OMessage);
                }
            }
            return View(ViewBag);
        }
    }
}