using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using BusinessLayer;
using PortalDataLayer;

namespace WebPortal
{
    public class Global : HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            TBusinessLayer BusinessLayer = new TBusinessLayer();
            string OMessage;
            Application["TblOpeningHours"] = BusinessLayer.GetOpeningHours(out OMessage);
        }


        void Application_End()
        {
            //
        }

        void Session_Start()
        {
            //Kullanıcı istekte bulunduğu an
        }

        void Session_End()
        {
            //
        }



    }
}