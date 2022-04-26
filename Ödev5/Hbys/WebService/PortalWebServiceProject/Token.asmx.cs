using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BusinessLayer;

namespace PortalWebServiceProject
{
    /// <summary>
    /// Summary description for Token
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Token : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetNow()
        {
            return DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        [WebMethod]
        public string GetToken(string ApiKey, string SecretKey, string Username, string Password, out string OMessage)
        {
            string result = "";
            OMessage = "";
            try
            {
                TBusinessLayer BusinessLayer = new TBusinessLayer();
                result = BusinessLayer.GetToken(ApiKey, SecretKey, Username, Password, out OMessage);
            }
            catch (Exception ex)
            {
                OMessage = ex.Message;
            }
            return result;
        }

        [WebMethod]
        public List<PortalDataLayer.VwDoctorsApointment> GetDoctorsApointments(string SecretKey, string Token)
        {
            List<PortalDataLayer.VwDoctorsApointment> result = new List<PortalDataLayer.VwDoctorsApointment>();

            TBusinessLayer BusinessLayer = new TBusinessLayer();
            List<string> Details = BusinessLayer.GetTokenDetails(Token).ToList();
            string OMessage;
            result = BusinessLayer.GetDoctorsApointments(Convert.ToInt32(Details[4]), out OMessage);
            return result;
        }


    }
}
