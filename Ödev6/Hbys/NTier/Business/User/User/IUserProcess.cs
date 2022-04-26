using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    internal interface IUserProcess
    {
        bool AddUser(TUser user, out string OMessage, out int UserId);
        bool UpdateUser(TUser user, out string OMessage);
        bool DeleteUser(int UserId, out string OMessage);
        List<TUser> GetUsers();
        List<TUser> GetUsers(int UserId);
        List<TUser> GetUsers(string UserName);
    }
}
