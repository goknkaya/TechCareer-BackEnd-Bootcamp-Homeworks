using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class THelper
    {
        private const string InvalidChars = "0123456789,.-*?\\='!+%&/;";
        public static bool HasNumber(object AValue)
        {
            bool result = true;
            try
            {
                int Number = Convert.ToInt32(AValue.ToString());
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
        public static bool IsValidIdentityNumber(long AValue)
        {
            bool result = false;
            try
            {
                if (AValue % 2 == 0)
                    result = true;
            }
            catch (Exception)
            {
                Console.WriteLine("hata");
            }
            return result;
        }
        public static bool IsValidString(string AValue)
        {
            bool result = true;
            try
            {
                for (int i = 0; i < AValue.Length; i++)
                {
                    string Chr = AValue.Substring(i, 1);
                    if (InvalidChars.IndexOf(Chr) > -1)
                    {
                        result = false;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
        public static uint ToAge(this DateTime ADate)
        {
            uint result = 0;
            result = (uint)DateTime.Now.Subtract(ADate).Days / 365;
            return result;
        }

        public static string GenerateToken(params string[] Parameters)
        {
            string result = "";
            foreach (string Parameter in Parameters)
            {
                result += Parameter + "|";
            }
            //byte[] BytArray = new byte[result.Length];
            //for (int i = 0; i < BytArray.Length; i++)
            //{
            //    BytArray[i] = Convert.ToByte(result[i]);
            //}
            byte[] BytArray = Encoding.ASCII.GetBytes(result);
            result = Convert.ToBase64String(BytArray);
            return result;
        }

        public static List<string> GetTokenDetails(string Token)
        {
            List<string> result = new List<string>();
            byte[] BytArray = Convert.FromBase64String(Token);
            string DecodeToken = Encoding.ASCII.GetString(BytArray);
            result = DecodeToken.Split('|').ToList();
            //foreach (string item in DecodeToken.Split('|'))
            //{
            //    result.Add(item);
            //}
            return result;
        }


    }

}
