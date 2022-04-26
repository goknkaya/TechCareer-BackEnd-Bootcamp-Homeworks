using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using PortalDataLayer;

namespace WebPortal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TBusinessLayer BusinessLayer = new TBusinessLayer();
            string OMessage;
            ViewBag.DoctorList = BusinessLayer.GetDoctors(out OMessage);
            ViewBag.BlogList = BusinessLayer.GetBlogs(out OMessage);
            return View(ViewBag);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult GetApointment()
        {
            string NameSurname = Request.Form["TxtNameSurname"].ToString();
            string Email = Request.Form["TxtEmail"].ToString();
            string PhoneNumber = Request.Form["TxtPhoneNumber"].ToString();
            string ApointmentDate = Request.Form["TxtApointmentDate"].ToString();
            string Doctor = Request.Form["TxtDoctor"].ToString();

            TBusinessLayer BusinessLayer = new TBusinessLayer();
            TblApointment Apointment = new TblApointment()
            {
                ApointmentDate = Convert.ToDateTime(ApointmentDate),
                NameSurname = NameSurname,
                Email = Email,
                PhoneNumber = PhoneNumber,
                DoctorId = Convert.ToInt32(Doctor)
            };
            string OMessage;
            bool Success = BusinessLayer.AddApointment(Apointment, out OMessage);
            TempData["Success"] = Success;
            TempData["Message"] = OMessage;
            return new RedirectResult("~/Home");
            //View("/Home/index.cshtml", ViewBag);
        }


    }
}