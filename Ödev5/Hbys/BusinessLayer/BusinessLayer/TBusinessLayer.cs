using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortalDataLayer;
using Helper;


namespace BusinessLayer
{
    public class TBusinessLayer
    {

        private DbWebPortalEntities Context;

        public TBusinessLayer()
        {
            Context = new DbWebPortalEntities();
        }

        public TBusinessLayer(bool NoConnect = false)
        {

        }

        public List<TblMailList> GetAllMailList(out string OMessage)
        {
            List<TblMailList> result = new List<TblMailList>();
            OMessage = "";
            try
            {
                result = (from birIsim in Context.TblMailList select birIsim).ToList();
                //var t = (from yeniIsim in Context.TblMailList select yeniIsim).ToList();
            }
            catch (Exception ex)
            {
                OMessage = ex.Message;
            }
            return result;
        }

        public bool ExistsMail(string MailAddress, out string OMessage)
        {
            bool result = false;
            OMessage = "";
            try
            {
                TblMailList Data = (from birIsim in Context.TblMailList where birIsim.Mail == MailAddress select birIsim).FirstOrDefault();
                if (Data != null)
                {
                    result = true;
                    OMessage = "Mail adresiniz daha önce kayıt edilmiş.";
                }
            }
            catch (Exception ex)
            {
                OMessage = ex.Message;
            }

            return result;
        }

        public void AddMailList(string MailAddress, out bool Addedd, out string OMessage)
        {
            OMessage = "";
            Addedd = false;
            try
            {
                TblMailList mail = new TblMailList();
                mail.Mail = MailAddress;
                Context.TblMailList.Add(mail);
                Addedd = true;
            }
            catch (Exception ex)
            {
                OMessage = ex.Message;
            }
        }

        public List<TblMailList> GetSqlData()
        {
            List<TblMailList> resut = null;
            Context.Database.SqlQuery<TblMailList>("select * from tblMailList where 1=2").ToList();
            return resut;
        }

        public void Delete(string MailAddress)
        {
            Context.Database.ExecuteSqlCommand("delete from tblMaillist where mailaddress='" + MailAddress + "'");
        }


        public List<VWOpeningHours> GetOpeningHours(out string OMessage)
        {
            List<VWOpeningHours> result = new List<VWOpeningHours>();
            OMessage = "";
            try
            {
                result = (from DataList in Context.VWOpeningHours where DataList.Active == true orderby DataList.DayOfWeek ascending select DataList).ToList();
            }
            catch (Exception ex)
            {
                OMessage = ex.Message;
            }
            return result;
        }

        public List<TblDoctors> GetDoctors(out string OMessage)
        {
            List<TblDoctors> result = new List<TblDoctors>();
            OMessage = "";

            try
            {
                result = (from DoctorList in Context.TblDoctors where DoctorList.Active == true orderby DoctorList.NameSurname ascending select DoctorList).ToList();
            }
            catch (Exception ex)
            {
                OMessage = ex.Message;
            }

            return result;
        }

        public bool AddApointment(TblApointment Apointment, out string OMessage)
        {
            OMessage = "";
            bool result = false;
            try
            {
                Context.TblApointment.Add(Apointment);
                Context.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                OMessage = ex.Message;
            }
            return result;
        }

        public List<TblBlog> GetBlogs(out string OMessage)
        {
            List<TblBlog> result = new List<TblBlog>();
            OMessage = "";
            try
            {
                result = Context.Database.SqlQuery<TblBlog>("select * from tblBlog order by BlogId desc").ToList();
            }
            catch (Exception ex)
            {
                OMessage = ex.Message;
            }
            return result;

        }

        public TblBlog GetBlogDetailByLink(string Link, out string OMessage)
        {
            TblBlog result = new TblBlog();
            OMessage = "";
            try
            {
                result = Context.Database.SqlQuery<TblBlog>("select * from tblBlog where BlogLink='" + Link + "'").FirstOrDefault();
            }
            catch (Exception ex)
            {
                OMessage = ex.Message;
            }
            return result;

        }

        public string GetToken(string ApiKey, string SecretKey, string Username, string Password, out string OMessage)
        {
            string result = "";
            OMessage = "Hatalı bilgi girişi";

            TblApiUsers ApiUser = (from data in Context.TblApiUsers where data.Username == Username select data).FirstOrDefault();

            if (ApiUser != null)
            {
                if (ApiUser.Password != Password)
                {
                    OMessage = "Hatalı bilgi girişi";
                }
                else if (ApiUser.Password == Password)
                {
                    if (ApiUser.ApiKey != ApiKey)
                    {
                        OMessage = "Hatalı bilgi girişi";
                    }
                    else if (ApiUser.ApiKey == ApiKey)
                    {
                        if (ApiUser.SecretKey != SecretKey)
                        {
                            OMessage = "Hatalı bilgi girişi";
                        }
                        else if (ApiUser.SecretKey == SecretKey)
                        {
                            OMessage = "";
                            result = THelper.GenerateToken(ApiUser.ApiKey, ApiUser.SecretKey, ApiUser.Username, ApiUser.UserId.ToString(), ApiUser.DoctorId.ToString(), Guid.NewGuid().ToString());
                        }
                    }
                }
            }


            return result;
        }

        public List<string> GetTokenDetails(string Token)
        {
            return THelper.GetTokenDetails(Token);
        }

        public List<VwDoctorsApointment> GetDoctorsApointments(int DoctorId,  out string OMessage)
        {
            List<VwDoctorsApointment> result = new List<VwDoctorsApointment>();
            OMessage = "";
            try
            {
                result = (from data in Context.VwDoctorsApointment where data.DoctorId == DoctorId orderby data.Id descending select data).ToList();
            }
            catch (Exception ex)
            {
                OMessage = ex.Message;
            }
            return result;
        }


    }

}
